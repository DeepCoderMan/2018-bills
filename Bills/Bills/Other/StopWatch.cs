using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Other
{
    /// <summary>
    /// 一些关于时间的计算
    /// </summary>
    class StopWatch
    {
        System.Diagnostics.Stopwatch stopwatch = new System.Diagnostics.Stopwatch();

        double _TimeOut;
        /// <summary>
        /// 耗时计算的起点
        /// </summary>
        public void StartElapse()
        {
            stopwatch.Start();
        }

        /// <summary>
        /// 耗时计算终点，返回从StartElapse开始经历的时间s
        /// </summary>
        /// <returns></returns>
        public double StopElapse()
        {
            stopwatch.Stop();
            return stopwatch.Elapsed.TotalSeconds;
        }


        /// <summary>
        /// 计算超时起点
        /// </summary>
        public void StartTimeOut()
        {
            stopwatch.Start();
        }

        /// <summary>
        /// 计算超时结束， tu:超时设定（ms）
        /// </summary>
        /// <param name="tu"></param>
        /// <returns></returns>
        public bool TimeOut(double tu)
        {
            stopwatch.Stop();
            _TimeOut += stopwatch.Elapsed.TotalSeconds;
            if (_TimeOut >= tu)
            {
                return true;
            }
            else
            {
                stopwatch.Start();
                return false;
            }
        }

        public double GetCurMilliseconed()
        {
            double cur = DateTime.Now.Millisecond;
            return cur;
        }
    }
}
