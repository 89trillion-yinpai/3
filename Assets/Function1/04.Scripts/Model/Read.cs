using System;

//序列化数据，将数据状态转换为可传输的格式
namespace Assets.Function1._04.Scripts.Model
{
    [Serializable]

    public class Read 
    {
        //声明属性及类型
        public string Uid;
        public string NickName;
        public string Avatar;
        public int Trophy;
        public string ThirdAvatar;
        public string OnlineStatus;
        public string Role;
        public string Abb;
        public int CountDown;
    }
}