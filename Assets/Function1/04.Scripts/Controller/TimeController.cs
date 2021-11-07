using System.Collections;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

namespace Assets.Function1._04.Scripts.Controller
{
    public class TimeController : JsonController
    {
        //防止重命名变量后丢失引用
        [FormerlySerializedAs("text")] public Text endTimeText;

        //倒计时总时间
        private int m_TotalTime;

        //显示倒计时文本
        private string printTime = "Ends  : ";

        private void Start()
        {
            //获取json给的倒计时数据
            m_TotalTime = CountDown;
            //开启协程，这个开启方法只适用于协程只有一个参数的时候
            StartCoroutine(Time());
        }

        string GetTime(int time) //让倒计时从天读到秒
        {
            int d = time / 86400;
            int h = time / 3600 - d * 24;
            int m = time / 60 - d * 24 * 60 - h * 60;
            int s = time - m * 60 - h * 3600 - d * 24 * 60 * 60;
            return printTime + d.ToString() + "d " + h.ToString() + "h " + m.ToString() + "m " + s.ToString() + "s ";
        }

        //每一帧检查倒计时是否结束
        private void Update()
        {
            if (m_TotalTime == 0)
            {
                Debug.Log("Game over");
            }
        }

        IEnumerator Time()
        {
            while (m_TotalTime > 0)
            {
                endTimeText.text = GetTime(m_TotalTime);
                //等待一秒后执行,模拟时间流动
                yield return new WaitForSeconds(1);
                m_TotalTime--;
            }
        }
    }
}