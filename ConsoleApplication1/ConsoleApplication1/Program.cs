﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

// Fackesを試すサンプル・アプリケーション
namespace FackesSampleApplication
{
    public class Program
    {
        static void Main(string[] args)
        {
        }

        /*
         * 年度を返すメソッドです。
         * 年度は4月～３月で区切ります。
         */
        private int GetYearCode()
        {
            DateTime now = new DateTime();

            if (now.Month >= 4)
            {
                return now.Year;
            }
            else
            {
                return now.Year -1;
            }
        }

        public int TestGenerateSample()
        {
            int x = 1;
            return x;
        }

        private String GetString()
        {
            return "hoga";
        }

    }

}
