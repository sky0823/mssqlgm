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
//https://dotblogs.com.tw/chichiblog/2017/10/16/155514
//https://dotblogs.com.tw/chichiblog/2017/10/16/163211

namespace MySqlT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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
                case "inventoryitem":
                    {
                        int rindex = chItemView.CurrentCell.RowIndex;
                        return chItemView.Rows[rindex].Cells[col].Value.ToString();
                    }                    
                case "inventoryequipment":
                    {
                        int rindex = chEquipView.CurrentCell.RowIndex;
                        return chEquipView.Rows[rindex].Cells[col].Value.ToString();
                    }
            }
            return "error";
        }
        private void Loadsql(string s)
        {
            string dbHost = HostText.Text;
            string dbUser = UserText.Text;
            string dbPass = PassText.Text;
            string dbName = NameText.Text;
            string dbPort = PortText.Text;
            //string connStr = "server=" + dbHost + ";uid=" + dbUser + ";pwd=" + dbPass + ";database=" + dbName + "; convert zero datetime=True" + ";Port=" + dbPort;
            //MySqlConnection conn = new MySqlConnection(connStr);
            MySqlConnection conn = new MySqlConnection("server=" + dbHost + ";uid=" + dbUser + ";pwd=" + dbPass + ";database=" + dbName + "; convert zero datetime=True" + ";Port=" + dbPort);

            
            // 連線到資料庫 
            try
            {
                conn.Open();
                String strSQL = " SELECT * FROM `" + s + "`";
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
                    case "inventoryitems":
                        chItemView.AutoGenerateColumns = true;
                        chItemView.DataSource = dataset.Tables[0];
                        break; 
                    case "inventoryequipment":
                        chEquipView.AutoGenerateColumns = true;
                        chEquipView.DataSource = dataset.Tables[0];
                        break;
                }
                MessageBox.Show("載入成功");
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
        private void LoadSinsql(string s, string strSQLKeyword)
        {
            string dbHost = HostText.Text;
            string dbUser = UserText.Text;
            string dbPass = PassText.Text;
            string dbName = NameText.Text;
            string dbPort = PortText.Text;
            //string connStr = "server=" + dbHost + ";uid=" + dbUser + ";pwd=" + dbPass + ";database=" + dbName + "; convert zero datetime=True" + ";Port=" + dbPort;
            //MySqlConnection conn = new MySqlConnection(connStr);
            MySqlConnection conn = new MySqlConnection("server=" + dbHost + ";uid=" + dbUser + ";pwd=" + dbPass + ";database=" + dbName + "; convert zero datetime=True" + ";Port=" + dbPort);


            // 連線到資料庫 
            try
            {
                conn.Open();
                MySqlDataAdapter sqlDA = new MySqlDataAdapter(strSQLKeyword, conn);
                DataSet dataset = new DataSet();
                sqlDA.Fill(dataset);
                if (dataset.Tables[0].Rows.Count == 0)
                {
                    MessageBox.Show("查無此角色");
                    AccountsView.DataSource = null;
                    chItemView.DataSource = null;
                    charactersView.DataSource = null;
                    return ;
                }
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
                    case "inventoryitems":
                        chItemView.AutoGenerateColumns = true;
                        chItemView.DataSource = dataset.Tables[0];
                        break;
                }
                MessageBox.Show("載入成功");
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
        private void UPDATEBsql(string s , string rindex)
        {
            string dbHost = HostText.Text;
            string dbUser = UserText.Text;
            string dbPass = PassText.Text;
            string dbName = NameText.Text;
            string dbPort = PortText.Text;
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
            String chItemstrsql = "UPDATE `inventoryitems` SET`itemid`=" + ItemitemidText.Text 
                            + ",`quantity`='" + ItemquantityText.Text
                            + "' WHERE (`inventoryitemid`='" + IteminventoryitemidText.Text + "')";
            String chEquipsql = "UPDATE `inventoryequipment` SET `upgradeslots`='" + EquipupgradeslotsText.Text
                            + "',`str`='" + EquipStrText.Text + "',`dex`='" + EquipDexText.Text
                            + "',`int`='" + EquipIntText.Text + "',`luk`='" + EquipLukText.Text
                            + "',`hp`='" + EquipHpText.Text + "',`mp`='" + EquipMpText.Text
                            + "',`watk`='" + EquipWatkText.Text + "',`matk`='" + EquipMatkText.Text
                            + "',`wdef`='" + EquipWdefText.Text + "',`mdef`='" + EquipMdefText.Text
                            + "',`acc`='" + EquipAccText.Text + "',`avoid`='" + EquipAvoidText.Text
                            + "',`speed`='" + EquipSpeedText.Text + "',`jump`='" + EquipJumpText.Text
                            + "' WHERE (`inventoryequipmentid`='" + Equipinventoryequipmentidlb.Text + "')";
            //MessageBox.Show(chEquipsql);

            //UPDATE `inventoryequipment` SET `upgradeslots`='35',`str`='550',`dex`='550',`int`='550',`luk`='550',`hp`='550',`mp`='550',`watk`='250',`matk`='250',`wdef`='550',`mdef`='550',`acc`='550',`avoid`='550',`speed`='120',`jump`='123'WHERE (`inventoryequipmentid`='2738')
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
                    case "inventoryitems":
                        {
                            sqlDA = new MySqlDataAdapter(chItemstrsql, conn);
                            DataSet dataset = new DataSet();
                            sqlDA.Fill(dataset);
                            break;
                        }
                    case "inventoryequipment":
                        {
                            sqlDA = new MySqlDataAdapter(chEquipsql, conn);
                            DataSet dataset = new DataSet();
                            sqlDA.Fill(dataset);
                            break;
                        }
                }
                MessageBox.Show("修改成功");
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

        //---
        private void AccountsView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
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
            chIDlb.Text= "角色編號: " + Rvview("characters", 0);
            accountidlb.Text = "帳號編號: "+ Rvview("characters", 1);
            //Worldlb.Text = Rvview("characters", 2);
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
        private void ChItemView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            IteminventoryitemidText.Text= Rvview("inventoryitem", 0);
            ItemchidText.Text = Rvview("inventoryitem", 1);
            ItemitemidText.Text = Rvview("inventoryitem", 4);
            //ItemiteminventorytypeText.Text = Rvview("inventoryitem", 5);
            //ItemitempositionText.Text = Rvview("inventoryitem", 6);
            ItemquantityText.Text = Rvview("inventoryitem", 7);            
            switch (Rvview("inventoryitem", 5))
            {
                case "-1":
                    ItemiteminventorytypeText.Text = "身上";
                    break;
                case "1":
                    ItemiteminventorytypeText.Text = "裝備";
                    break;
                case "2":
                    ItemiteminventorytypeText.Text = "消耗";
                    break;
                case "3":
                    ItemiteminventorytypeText.Text = "裝飾";
                    break;
                case "4":
                    ItemiteminventorytypeText.Text = "其他";
                    break;
                case "5":
                    ItemiteminventorytypeText.Text = "特殊";
                    break;
            }
            switch(Rvview("inventoryitem", 6))
            {
                case "-5":
                    ItemitempositionText.Text = "上衣/套服";
                    break;
                case "-6":
                    ItemitempositionText.Text = "褲子";
                    break;
                case "-7":
                    ItemitempositionText.Text = "鞋子";
                    break;
                case "-11":
                    ItemitempositionText.Text = "武器";
                    break;
                case "-101":
                    ItemitempositionText.Text = "點數-帽子";
                    break;
                case "-102":
                    ItemitempositionText.Text = "點數-臉飾";
                    break;
                case "-103":
                    ItemitempositionText.Text = "點數-眼飾";
                    break;
                case "-105":
                    ItemitempositionText.Text = "點數-上衣/套服";
                    break;
                case "-106":
                    ItemitempositionText.Text = "點數-褲子";
                    break;
                case "-107":
                    ItemitempositionText.Text = "點數-鞋子";
                    break;
                case "-108":
                    ItemitempositionText.Text = "點數-手套";
                    break;
                case "-109":
                    ItemitempositionText.Text = "點數-披風";
                    break;
                case "-111":
                    ItemitempositionText.Text = "點數-武器";
                    break;
                case "-112":
                    ItemitempositionText.Text = "點數-戒指左下";
                    break;
                case "-113":
                    ItemitempositionText.Text = "點數-戒指右下";
                    break;
                case "-114":
                    ItemitempositionText.Text = "點數-寵物裝備";
                    break;
                case "-115":
                    ItemitempositionText.Text = "點數-戒指左上";
                    break;
                case "-116":
                    ItemitempositionText.Text = "點數-戒指右上";
                    break;
                default:
                    ItemitempositionText.Text = "第"+ Rvview("inventoryitem", 6)+"格";
                    break;
            }

        }
        private void ChEquipView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Equipinventoryequipmentidlb.Text=  Rvview("inventoryequipment", 0);
            Equipinventoryitemidlb.Text = "身上物品編號: " + Rvview("inventoryequipment", 1);
            Equiplevellb.Text = "成功衝卷次數: "+ Rvview("inventoryequipment", 3);
            EquipupgradeslotsText.Text = Rvview("inventoryequipment", 2);
            EquipStrText.Text = Rvview("inventoryequipment", 4);
            EquipDexText.Text = Rvview("inventoryequipment", 5);
            EquipIntText.Text = Rvview("inventoryequipment", 6);
            EquipLukText.Text = Rvview("inventoryequipment", 7);
            EquipHpText.Text = Rvview("inventoryequipment", 8);
            EquipMpText.Text = Rvview("inventoryequipment", 9);
            EquipWatkText.Text = Rvview("inventoryequipment", 10);
            EquipMatkText.Text = Rvview("inventoryequipment", 11);
            EquipWdefText.Text = Rvview("inventoryequipment", 12);
            EquipMdefText.Text = Rvview("inventoryequipment", 13);
            EquipAccText.Text = Rvview("inventoryequipment", 14);
            EquipAvoidText.Text = Rvview("inventoryequipment", 15);
            EquipSpeedText.Text = Rvview("inventoryequipment", 17);
            EquipJumpText.Text = Rvview("inventoryequipment", 18);
        }
        //-------------------------------------------------------------------------------------------
        private void Loadaccbtn_Click(object sender, EventArgs e)
        {
            Loadsql("accounts");
        }
        private void AccountSinBtn_Click(object sender, EventArgs e)
        {
            if (AccountSinText.Text != "")
                LoadSinsql("accounts", "SELECT * FROM accounts WHERE name = (SELECT name FROM accounts WHERE name LIKE '" + AccountSinText.Text + "')");
            else
                MessageBox.Show("請輸入帳號在查詢");
        }
        private void UPDATEaccBtn_Click(object sender, EventArgs e)
        {
            if (AccountsText.Text != "帳號")
            { 
                string rindex = AccountsView.Rows[AccountsView.CurrentCell.RowIndex].Cells[0].Value.ToString();
                UPDATEBsql("accounts", rindex);
            }
            else
                MessageBox.Show("請先載入再嘗試儲存修改");
        }
        //---
        private void Charactersbtn_Click(object sender, EventArgs e)
        {
            Loadsql("characters");
        }
        private void CharatersSinbtn_Click(object sender, EventArgs e)
        {
            if (charactersSinText.Text != "")
                LoadSinsql("characters", "SELECT * FROM characters WHERE name = (SELECT name FROM characters WHERE name LIKE '%" + charactersSinText.Text + "%')");
            else
                MessageBox.Show("請輸入角色名稱在查詢");
        }
        private void UPDATEchBtn_Click(object sender, EventArgs e)
        {
            if (chLevelText.Text != "角色等級")
            {
                string rindex = charactersView.Rows[charactersView.CurrentCell.RowIndex].Cells[0].Value.ToString();
                UPDATEBsql("characters", rindex);
            }
            else
                MessageBox.Show("請先載入再嘗試儲存修改");
        }
        //---
        private void ChItemloadbtn_Click(object sender, EventArgs e)
        {
            Loadsql("inventoryitems");
        }
        private void UPDATEchItemBtn_Click(object sender, EventArgs e)
        {
            if (IteminventoryitemidText.Text != "物品當前編號")
                UPDATEBsql("inventoryitems","");
            else
                MessageBox.Show("請先載入再嘗試儲存修改");
        }
        private void ChItemloadSinbtn_Click(object sender, EventArgs e)
        {
            if (chnameloadItemText.Text != "")
                LoadSinsql("inventoryitems", "SELECT * FROM inventoryitems WHERE characterid = (SELECT id FROM characters WHERE name LIKE '%" + chnameloadItemText.Text + "%')");
            else
                MessageBox.Show("請輸入角色名稱在查詢");
        }
        //---
        private void ChEquiploadAllbtn_Click(object sender, EventArgs e)
        {
            Loadsql("inventoryequipment");
        }
        private void UPDATEchEquipBtn_Click(object sender, EventArgs e)
        {
            if (EquipupgradeslotsText.Text != "衝捲數")
                UPDATEBsql("inventoryequipment", "");
            else
                MessageBox.Show("請先載入再嘗試儲存修改");
        }
        //---

        //--------------------------------------------------------------------------------------------------------
        void Num_Only(KeyPressEventArgs e)
        {
            int a = e.KeyChar;
            e.Handled = true;
            if (a >= 48 && a <= 57) e.Handled = false;
            if (a == 13) e.Handled = false;
            if (a == 127) e.Handled = false;
            if (a == 8) e.Handled = false;
        }
        private void MPointsText_KeyPress(object sender, KeyPressEventArgs e)
        {
            Num_Only(e);
        }

        private void ACashText_KeyPress(object sender, KeyPressEventArgs e)
        {
            Num_Only(e);
        }

        private void ChLevelText_KeyPress(object sender, KeyPressEventArgs e)
        {
            Num_Only(e);
        }

        private void ChStrText_KeyPress(object sender, KeyPressEventArgs e)
        {
            Num_Only(e);
        }

        private void ChLukText_KeyPress(object sender, KeyPressEventArgs e)
        {
            Num_Only(e);
        }

        private void ChDexText_KeyPress(object sender, KeyPressEventArgs e)
        {
            Num_Only(e);
        }

        private void ChIntText_KeyPress(object sender, KeyPressEventArgs e)
        {
            Num_Only(e);
        }

        private void ChApText_KeyPress(object sender, KeyPressEventArgs e)
        {
            Num_Only(e);
        }

        private void ChMesoText_KeyPress(object sender, KeyPressEventArgs e)
        {
            Num_Only(e);
        }

        private void ChExpText_KeyPress(object sender, KeyPressEventArgs e)
        {
            Num_Only(e);
        }

        private void ChHpText_KeyPress(object sender, KeyPressEventArgs e)
        {
            Num_Only(e);
        }

        private void ChMpText_KeyPress(object sender, KeyPressEventArgs e)
        {
            Num_Only(e);
        }

        private void ChMaxhpText_KeyPress(object sender, KeyPressEventArgs e)
        {
            Num_Only(e);
        }

        private void ChMaxmpText_KeyPress(object sender, KeyPressEventArgs e)
        {
            Num_Only(e);
        }

        private void ChGmText_KeyPress(object sender, KeyPressEventArgs e)
        {
            Num_Only(e);
        }

        private void ChMapText_KeyPress(object sender, KeyPressEventArgs e)
        {
            Num_Only(e);
        }

        private void ItemitemidText_KeyPress(object sender, KeyPressEventArgs e)
        {
            Num_Only(e);
        }

        private void ItemquantityText_KeyPress(object sender, KeyPressEventArgs e)
        {
            Num_Only(e);
        }

        private void ItemchidText_KeyPress(object sender, KeyPressEventArgs e)
        {
            Num_Only(e);
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
