using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

//https://www.1keydata.com/tw/sql/sql-syntax.html   ---SQL語法
//https://dev.mysql.com/doc/refman/8.0/en/server-error-reference.html

namespace MySqlT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Loadsql(string s)
        {
            string dbHost = HostText.Text;
            string dbUser = UserText.Text;
            string dbPass = PassText.Text;
            string dbName = NameText.Text;
            string dbPort = PortText.Text;
            string connStr = "server=" + dbHost + ";uid=" + dbUser + ";pwd=" + dbPass + ";database=" + dbName + "; convert zero datetime=True" + ";Port=" + dbPort;
            //string connStr = "server=" + H + ";uid=" + U + ";pwd=" + P + ";database=" + N + "; convert zero datetime=True" + ";Port=" + port;
            MySqlConnection conn = new MySqlConnection(connStr);

            String strSQL = " SELECT * FROM `" + s + "` WHERE 1 LIMIT 0,30";

            //String strSQL = " SELECT * FROM `accounts` WHERE 1 LIMIT 0,30";

            // 連線到資料庫 
            try
            {
                conn.Open();
                MySqlDataAdapter sqlDA = new MySqlDataAdapter(strSQL, conn);
                DataSet dataset = new DataSet();
                sqlDA.Fill(dataset);
                switch (s)
                { 
                    case "accounts":
                        AccountsView.AutoGenerateColumns = true;
                        AccountsView.DataSource = dataset.Tables[0];
                        break;
                    case "characters":
                        charactersView.AutoGenerateColumns = true;
                        charactersView.DataSource = dataset.Tables[0];
                        break;
                }
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("無法連線到資料庫.請再確認參數是否正確或資料庫是否開啟.");
                        break;
                    case 1045:
                        MessageBox.Show("使用者帳號或密碼錯誤,請再試一次.");
                        break;
                    default:
                        MessageBox.Show("Error:" + ex.Number + '\n' + ex.Message);
                        break;
                }
            }
           MessageBox.Show("載入成功");
           conn.Close();
        }
        public string Rvview(string sel, int col)
        {
            switch (sel)
            {
                case "accounts":
                    {
                        int rindex = AccountsView.CurrentCell.RowIndex;
                        return AccountsView.Rows[rindex].Cells[col].Value.ToString();
                    }
                case "characters":
                    {
                        int rindex = charactersView.CurrentCell.RowIndex;
                        return charactersView.Rows[rindex].Cells[col].Value.ToString();
                    }
            }
            return "error";
        }

        private void UPDATEBsql(string s)
        {
            string dbHost = HostText.Text;
            string dbUser = UserText.Text;
            string dbPass = PassText.Text;
            string dbName = NameText.Text;
            string dbPort = PortText.Text;
            string rindex = AccountsView.Rows[AccountsView.CurrentCell.RowIndex].Cells[0].Value.ToString();
            // 如果有特殊的編碼在database後面請加上;CharSet=編碼, utf8請使用utf8_general_ci 
            string connStr = "server=" + dbHost + ";uid=" + dbUser + ";pwd=" + dbPass + ";database=" + dbName + "; convert zero datetime=True" + ";Port=" + dbPort;
            MySqlConnection conn = new MySqlConnection(connStr);
            String strsql = "UPDATE `" + s + "` SET `ACash`='" + ACashText.Text + "',"
                            + "`mPoints`= '" + mPointsText.Text + "',"
                            + "`gender`= '" + genderText.Text
                            + "'WHERE (`id`='" + rindex + "')";
            String chstrsql = "UPDATE `" + s + "` SET `name`='" + chnameText.Text
                            + "',`level`='" + chLevelText.Text + "',`exp`='" + chExpText.Text + "',`str`='" + chStrText.Text
                            + "',`dex`='" + chDexText.Text + "',`luk`='" + chLukText.Text + "',`int`='" + chIntText.Text
                            + "',`hp`='" + chHpText.Text + "',`mp`='" + chMpText.Text + "',`maxhp`='" + chMaxhpText.Text
                            + "',`maxmp`='" + chMaxmpText.Text + "',`meso`='" + chMesoText.Text + "',`job`='" + chJobText.Text
                            + "',`ap`='" + chApText.Text + "',`map`='" + chMapText.Text + "',`gm`='" + chGmText.Text
                            + "',`sp`='" + chSpText.Text + ",0,0,0,0,0,0,0,0,0' WHERE (`id`='" + rindex + "')";

            // 連線到資料庫 
            try
            {
                conn.Open();
                MySqlDataAdapter sqlDA;
                switch (s)
                {
                    case "accounts":
                        {
                            sqlDA = new MySqlDataAdapter(strsql, conn);
                            DataSet dataset = new DataSet();
                            sqlDA.Fill(dataset);
                            break;
                        }
                    case "characters":
                        {
                            sqlDA = new MySqlDataAdapter(chstrsql, conn);
                            DataSet dataset = new DataSet();
                            sqlDA.Fill(dataset);
                            break;
                        }       
                }                
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("無法連線到資料庫.請再確認參數是否正確或資料庫是否開啟.");
                        break;
                    case 1045:
                        MessageBox.Show("使用者帳號或密碼錯誤,請再試一次.");
                        break;
                    default:
                        MessageBox.Show("Error:" + ex.Number + '\n' + ex.Message);
                        break;
                }
            }
            conn.Close();
        }
        private void Loadaccbtn_Click(object sender, EventArgs e)
        {         
            Loadsql("accounts");
        }
        private void UPDATEaccBtn_Click(object sender, EventArgs e)
        {
            if (AccountsText.Text != "帳號")
                UPDATEBsql("accounts");
            else
                MessageBox.Show("請先載入再嘗試儲存修改");
        }
        private void Charactersbtn_Click(object sender, EventArgs e)
        {
            Loadsql("characters");
        }
        private void UPDATEchBtn_Click(object sender, EventArgs e)
        {
            if (chLevelText.Text != "角色等級")
                UPDATEBsql("characters");
            else
                MessageBox.Show("請先載入再嘗試儲存修改");
        }
        private void AccountsView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //string value= dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[dataGridView1.CurrentCell.ColumnIndex].Value.ToString();
           /* int rindex = AccountsView.CurrentCell.RowIndex;
            IDlb.Text= "ID:"+AccountsView.Rows[rindex].Cells[0].Value.ToString();
            loggedinlb.Text ="登入狀態:"+ AccountsView.Rows[rindex].Cells[6].Value.ToString();
            lastloginlb.Text = "最後登入時間:"+AccountsView.Rows[rindex].Cells[7].Value.ToString();
            bannedlb.Text = "封鎖狀態:"+AccountsView.Rows[rindex].Cells[10].Value.ToString();
            SessionIPlb.Text = "IP:"+AccountsView.Rows[rindex].Cells[20].Value.ToString();
            AccountsText.Text = AccountsView.Rows[rindex].Cells[1].Value.ToString();//1
            PasswordText.Text = AccountsView.Rows[rindex].Cells[2].Value.ToString();//2
            TwoPasswordText.Text = AccountsView.Rows[rindex].Cells[4].Value.ToString();//4
            GmText.Text = AccountsView.Rows[rindex].Cells[12].Value.ToString();//12
            ACashText.Text = AccountsView.Rows[rindex].Cells[17].Value.ToString();//17
            mPointText.Text = AccountsView.Rows[rindex].Cells[18].Value.ToString();//18
            genderText.Text = AccountsView.Rows[rindex].Cells[19].Value.ToString();//19*/
            // AccountsText.Text = dataGridView1[dataGridView1.CurrentCell.ColumnIndex,dataGridView1.CurrentCell.RowIndex].Value;
            IDlb.Text = "ID:" + Rvview("accounts", 0);
            loggedinlb.Text = "登入狀態:" + Rvview("accounts", 6);
            lastloginlb.Text = "最後登入時間:" + Rvview("accounts", 7);
            bannedlb.Text = "封鎖狀態:" + Rvview("accounts", 10);
            SessionIPlb.Text = "IP:" + Rvview("accounts", 20);
            AccountsText.Text = Rvview("accounts", 1);
            PasswordText.Text = Rvview("accounts", 2);
            TwoPasswordText.Text = Rvview("accounts", 4);
            GmText.Text = Rvview("accounts", 12);
            ACashText.Text = Rvview("accounts", 17);
            mPointsText.Text = Rvview("accounts", 18);
            genderText.Text = Rvview("accounts", 19);
        }

        private void CharactersView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //int rindex = charactersView.CurrentCell.RowIndex;
            chnameText.Text = Rvview("characters", 3);
            chLevelText.Text = Rvview("characters", 4);
            chExpText.Text = Rvview("characters", 5);
            chStrText.Text = Rvview("characters", 6);
            chDexText.Text = Rvview("characters", 7);
            chLukText.Text = Rvview("characters", 8);
            chIntText.Text = Rvview("characters", 9);
            chHpText.Text = Rvview("characters", 10);
            chMaxhpText.Text = Rvview("characters", 12);
            chMpText.Text = Rvview("characters", 11);
            chMaxmpText.Text = Rvview("characters",13);
            chJobText.Text = Rvview("characters", 16);
            chSpText.Text = Rvview("characters", 36);
            chApText.Text = Rvview("characters", 22);
            chMesoText.Text = Rvview("characters", 14);
            chMapText.Text = Rvview("characters", 23);
            chGmText.Text = Rvview("characters", 25);
        }
    }
}


/*
string dbHost = "localhost";
string dbUser = "root";
string dbPass = "";
string dbName = "87maplestory";
string dbPort = "3306";


string dbHost = HostText.Text;
string dbUser = UserText.Text;
string dbPass = PassText.Text;
string dbName = NameText.Text;
string dbPort = PortText.Text;
Loadsql(dbHost, dbUser, dbPass, dbName, dbPort,"accounts");

// 如果有特殊的編碼在database後面請加上;CharSet=編碼, utf8請使用utf8_general_ci 
string connStr = "server=" + dbHost + ";uid=" + dbUser + ";pwd=" + dbPass + ";database=" + dbName + "; convert zero datetime=True" + ";Port=" + dbPort;
MySqlConnection conn = new MySqlConnection(connStr);

String strSQL =" SELECT * FROM `accounts` WHERE 1 LIMIT 0,30"; //選擇accounts 30筆資料
                                                               //"SELECT `name`FROM `accounts`LIMIT 0,30";


// 連線到資料庫 
try
{
    conn.Open();
    MySqlDataAdapter sqlDA = new MySqlDataAdapter(strSQL, conn);
    DataSet dataset = new DataSet();
    sqlDA.Fill(dataset);
    AccountsView.AutoGenerateColumns = true;
    AccountsView.DataSource = dataset.Tables[0];
}
catch (MySql.Data.MySqlClient.MySqlException ex)
{
    switch (ex.Number)
    {
        case 0:
            MessageBox.Show("無法連線到資料庫.請再確認參數是否正確或資料庫是否開啟.");
            break;
        case 1045:
            MessageBox.Show("使用者帳號或密碼錯誤,請再試一次.");
            break;
        default:
            MessageBox.Show("Error:"+ex.Number+'\n'+ex.Message);
            break;
    }
}
conn.Close();*/
