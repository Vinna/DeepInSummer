﻿using System;
#if NET1
#else
using System.Collections.Generic;
#endif
using System.Text;
using System.Collections;

namespace Discuz.Web.Services.API
{
    public class ErrorDetails : Hashtable
    {
        /*
         * 错误提示信息码(Code)的赋值规则为
         * 1-99为系统级异常信息
         * 100-999为接口权限级异常信息
         * 1000以上为任务级(Commmand)异常信息,且为了方便区分归类,
         * 1K段为Auth类
         * 2K段为Users
         * 3K段为Forums
         * 4K段为Topics
         * 5K段为Message
         * 6K段为Notification
         * 
         */



        public ErrorDetails()
        {
            #region System
            this.Add(1, "未知错误,请再次提交该任务");
            this.Add(2, "服务目前不可使用");
            this.Add(3, "调用了不存在的方法或方法内部错误");
            this.Add(4, "整合程序已达到允许的最大同时请求数");
            this.Add(5, "指定参数不存在或不是有效参数，请检查是否有必要参数未提交，或者提交的参数值不是合法的");

            #endregion

            #region Authority
            this.Add(100, "所提交的api_key未关联到任何设定程序");
            this.Add(101, "请求来自一个未被当前整合程序允许的远程地址");
            this.Add(102, "应用程序的请求由于权限问题被拒绝");
            this.Add(103, "当前会话所提交的call_id没有大于前一次的call_id");
            this.Add(104, "签名(sig)参数不正确");
            this.Add(105, "session_key已过期或失效,请重定向让用户重新登录并获得新的session_key");

            #endregion

            #region AuthCommands
            this.Add(1000, "当前不允许注册或不满足注册条件");
            this.Add(1001, "Email已存在或非法");
            this.Add(1002, "用户名称已被注册");
            this.Add(1003, "用户名称不合法");
            this.Add(1004, "当前已有用户登录,不能注册新用户");
            this.Add(1005, "当前用户多次登录失败,15分钟内无法登录");
            this.Add(1006, "多个用户使用了该登录E-mail,无法登录");
            this.Add(1007, "密码错误,登录失败");
            this.Add(1008, "用户的用户组禁止访问,登录失败");

            #endregion

            #region UserCommands
            this.Add(2000, "当前指定的用户不存在,无法操作");
            this.Add(2001, "原密码输入不正确,无法修改密码");
            #endregion

            #region ForumsCommands
            this.Add(3000, "版块RewriteName已存在或非法");
            this.Add(3001, "指定版块不存在或不是合法版块");

            #endregion

            #region TopicCommands
            this.Add(4001, "信息中存在非法、垃圾信息,任务被拒绝");
            this.Add(4002, "主题已关闭,无法通过API进行回复");
            this.Add(4003, "当前用户阅读权限不足,无法查看主题或回复");
            this.Add(4004, "版块设置了密码,无法访问和操作资源");
            this.Add(4005, "没有版块访问权限");
            this.Add(4006, "没有回复权限");
            this.Add(4007, "见习期用户无法发帖");
            this.Add(4008, "标题太长或含有非法字符");
            this.Add(4009, "内容长度不符合系统要求");
            this.Add(4010, "没有发布主题的权限");
            this.Add(4011, "没有编辑权限");
            this.Add(4012, "未能成功关联到一个用户,无法编辑");
            this.Add(4013, "重复提交的信息,任务被拒绝");
            this.Add(4014, "指定主题不存在");
            this.Add(4015, "未超出发帖时间间隔");
            #endregion

            #region MessageCommands
            this.Add(5000, "发件人uid无效,系统中不存在指定uid的用户");
            this.Add(5001, "设置了过多的收件人ID,任务被拒绝");
            this.Add(5002, "未超出指定调用间隔时间");

            #endregion

            #region NotificationCommands
            #endregion
        }
    }
}