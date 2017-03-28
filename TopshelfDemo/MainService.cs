using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TopshelfDemo
{
    public class MainService
    {
        public MainService()
        {

        }

        public bool Start()
        {
            LogHelper.Debug(() => string.Format("TopshelfDemo服务启动成功!"));

            return true;
        }

        public bool Stop()
        {
            LogHelper.Debug(() => string.Format("TopshelfDemo服务停止!"));

            return true;
        }

    }
}
