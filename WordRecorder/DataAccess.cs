﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OracleClient;

namespace WordRecorder
{
    class DataAccess
    {
        //OracleConnection型の変数を保持
        OracleConnection con =
        new OracleConnection("User ID=scott;Password=tiger;Data Source=orcl;");;
        //接続メソッド
	public void openDataAccess()
        {
            //接続を開く
            con.Open();
        }
        //切断メソッド
        public void closeDataAccess()
        {
            //接続を閉じる
            con.Close();
        }

        //データベースに登録するメソッド（引数に渡した二つの値を）
        public void insertRow(string name, string word)
        {

            //データベースへの接続
            openDataAccess();
            //トランザクションオブジェクトをConnectionから生成
            OracleTransaction tran = con.BeginTransaction();

            //Oracleに対してのCommandを作成する。
            OracleCommand  command = con.CreateCommand

            //SQLを設定する
            OracleDataAdapter adpt = new OracleDataAdapter();
            adpt.SelectCommand = new OracleCommand("SELECT * FROM DEPT", con);

            //実行するCommandを、トランザクションに含める

            //insert文を発行する。戻り値は、結果行数。使わないけれど。

            //トランザクションのコミット

            //データベースのクローズ
        }

        //データベースからの一件分のデータをランダムに取得し、文字列で返すメソッド
        public string getRandomRow()
        {
            string row; //出力データを格納する
                        //ランダムオブジェクトの生成
            Random rd = new Random();
            //こねくしょんのOpen

            //新しくAdapterを生成する。

            //Adapterに対してのCommandを生成する。

            //DataTableの生成

            //SelectCommandの発行

            //ランダムオブジェクトから乱数をもらう。範囲は、１から行の数の間。
            int i = rd.Next(0, dt.Rows.Count);
            //乱数を行番号として、1列目と2列目の値を取得し、変数rowに格納。

            return row;

        }

    }
}
