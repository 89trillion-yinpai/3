using System.Collections.Generic;
using Assets.Function1._04.Scripts.Model;
using SimpleJSON;
using UnityEngine;

namespace Assets.Function1._04.Scripts.Controller
{
    public class JsonController : MonoBehaviour
    {
        public int CountDown;

        //声明列表存储json数据
        public List<Read> item;
        public int Num;

        void Awake()
        {
            Duqu();
        }

        //读取json数据
        public void Duqu()
        {
            item.Clear();

            TextAsset playText = Resources.Load("ranklist") as TextAsset;
            JSONNode jsonObject = JSON.Parse(playText.text);
            CountDown = jsonObject["countDown"];
            Num = jsonObject[1].Count;
            for (int i = 0; i < Num; i++)
            {
                Read fieldRead = new Read();
                fieldRead.Uid = jsonObject[1][i]["uid"];
                fieldRead.NickName = jsonObject[1][i]["nickName"];
                fieldRead.Avatar = jsonObject[1][i]["avatar"];
                fieldRead.Trophy = jsonObject[1][i]["trophy"];
                fieldRead.ThirdAvatar = jsonObject[1][i]["thirdAvatar"];
                fieldRead.OnlineStatus = jsonObject[1][i]["onlineStatus"];
                fieldRead.Role = jsonObject[1][i]["role"];
                fieldRead.Abb = jsonObject[1][i]["abb"];
                item.Add(fieldRead);
            }

            item.Sort((x, y) => { return -x.Trophy.CompareTo(y.Trophy); });
        }
    }
}