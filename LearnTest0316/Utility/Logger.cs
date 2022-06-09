using System;
using log4net;
using log4net.Config;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LearnTest0316.Utility
{
    public class Logger
    {
        private ILog loger = null;

        /// <summary>
        /// 讀取配置文件的--靜態構造函數--整個進程指讀取一次;
        /// </summary>
        static Logger() {
            XmlConfigurator.Configure(new FileInfo(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "CfgFiles\\log4net.config")));
            ILog log = LogManager.GetLogger(typeof(Logger));
            log.Info("系統初始化Logger模塊");
        }
        
        public Logger(Type type) {
            loger = LogManager.GetLogger(type);
        }

        /// <summary>
        /// Log4 日誌;
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="ex"></param>
        public void Error(string msg = "出現異常", Exception ex = null) {
            Console.WriteLine(msg);
            loger.Error(msg, ex);
        }


        /// <summary>
        /// Log4 日誌;
        /// </summary>
        /// <param name="msg"></param>
        public void Warn(string msg) {
            Console.WriteLine(msg);
            loger.Warn(msg);
        }

        /// <summary>
        /// Log4 日誌;
        /// </summary>
        /// <param name="msg"></param>
        public void Info(string msg) {
            Console.WriteLine(msg);
            loger.Info(msg);
        }

        /// <summary>
        /// Log4 日誌;
        /// </summary>
        /// <param name="msg"></param>
        public void Debug(string msg)
        {
            Console.WriteLine(msg);
            loger.Debug(msg);
        }
    }
}