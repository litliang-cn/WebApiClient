﻿using System;

namespace WebApiClient
{
    /// <summary>
    /// 表示Http接口异常基础类
    /// </summary>
    public class HttpApiException : Exception
    {
        /// <summary>
        /// Http接口异常基础类
        /// </summary>
        public HttpApiException()
            : base()
        {
        }

        /// <summary>
        /// Http接口异常基础类
        /// </summary>
        /// <param name="message">异常消息</param>
        public HttpApiException(string message)
            : base(message)
        {
        }

        /// <summary>
        /// Http接口异常基础类
        /// </summary>
        /// <param name="message">异常消息</param>
        /// <param name="inner">内部异常</param>
        public HttpApiException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}