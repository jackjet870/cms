﻿//
// Copyright (C) 2007-2008 OPSoft INC,All rights reseved.
// 
// Project: OPS.OPSite.Manager
// FileName : Ajax.cs
// Author : PC-CWLIU (new.min@msn.com)
// Create : 2011/10/15 21:16:56
// Description :
//
// Get infromation of this software,please visit our site http://www.ops.cc
//
// Modify:
//      2012-11-28  20:20   :  修改验证码不能正常显示的问题
//

namespace Ops.Cms.WebManager
{
    using System;
    using System.Web;

    /// <summary>
    /// 验证码管理器
    /// </summary>
    internal static class VerifyCodeManager
    {
        /// <summary>
        /// 添加词语
        /// </summary>
        /// <param name="word"></param>
        public static void AddWord(string word)
        {
            if (word != null)
            {
                HttpContext.Current.Session["$manager.login.verifycode"] = word;
            }
        }

        /// <summary>
        /// 比较验证码
        /// </summary>
        /// <param name="inputWord"></param>
        /// <returns></returns>
        public static bool Compare(string inputWord)
        {
            var sess = HttpContext.Current.Session["$manager.login.verifycode"];
            if (sess != null)
            {
                return String.Compare(inputWord, sess.ToString(), true) == 0;
            }
            return true;
        }
    }
}
