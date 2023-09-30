using System.Xml.Linq;
using System;
using Lab1Neil.Models;
using static System.Net.Mime.MediaTypeNames;

namespace Lab1Neil.DataSource
{
    public class StudentData
    {
        static StudentData? instance;
        public List<Student> myList = new List<Student>();
        public Student StudentLogged { get; set; }

        protected StudentData()
        {
            myList.Add(new Student("7", "Steve Jobs", "steve@cloud.com","7","https://www.nj.com/resizer/zovGSasCaR41h_yUGYHXbVTQW2A=/1280x0/smart/cloudfront-us-east-1.images.arcpublishing.com/advancelocal/SJGKVE5UNVESVCW7BBOHKQCZVE.jpg"));
            myList.Add(new Student("2182620", "Kaiya Maldonado","malattia@msn.com", "MQPOSXIY", "https://i.kinja-img.com/gawker-media/image/upload/t_original/ijsi5fzb1nbkbhxa2gc1.png"));
            myList.Add(new Student("7119781", "Baron Hooper", "claesjac@msn.com","NEOQBDCR", "https://dt2sdf0db8zob.cloudfront.net/wp-content/uploads/2019/12/9-Best-Online-Avatars-and-How-to-Make-Your-Own-for-Free-image1-5.png"));
            myList.Add(new Student("6475788", "Denisse Mosley", "hstiles@aol.com","RLRXNHQQ", "https://www.technipages.com/wp-content/uploads/2020/12/create-cartoon-avatar-from-photo-600x381.png"));
            myList.Add(new Student("9482204", "Asa Krueger", "pizza@icloud.com","FYWXEUCV", "https://thumbs.dreamstime.com/b/black-employee-woman-avatar-flat-icon-series-afro-american-office-worker-green-sweater-glasses-isolated-white-95781063.jpg"));
            myList.Add(new Student("5092103", "Lindsey Nunez", "donev@aol.com","BUWTSSNN", "https://cdn1.vectorstock.com/i/thumb-large/38/70/young-woman-wearing-eyeglasses-icon-vector-36593870.jpg"));
            myList.Add(new Student("9498666", "Macey Clements", "arathi@msn.com","WQYFXRMC", "https://cdn2.vectorstock.com/i/thumb-large/19/21/geeky-girl-vector-3251921.jpg"));
            myList.Add(new Student("9322861", "Conner Jordan", "tamas@gmail.com","NXQUWNCI", "https://media.gettyimages.com/vectors/human-face-avatar-icon-profile-for-social-network-man-vector-vector-id1227618801"));
            myList.Add(new Student("6686117", "Micheal Lara","tubajon@comcast.net", "NXQUWNCI", "https://thumbs.dreamstime.com/b/cartoon-avatar-man-front-view-graphic-brown-hair-wearing-eyeglasses-over-isolated-background-illustration-73243082.jpg"));
            myList.Add(new Student("3861660", "Cullen Dickson","sdjupedal@outlook.com", "RLRXNHQQ", "https://thumbs.dreamstime.com/b/black-tycoon-avatar-flat-icon-white-series-afro-american-businessman-secret-agent-jacket-green-tie-95789619.jpg"));
            myList.Add(new Student("2", "Janae Shepherd","sdexter@yahoo.ca", "2","https://cdn.xxl.thumbs.canstockphoto.com/beautiful-woman-afro-with-glasses-avatar-character-icon-vector-illustration-design-image_csp76770577.jpg"));
            myList.Add(new Student("4133410", "Addisyn Wade","leocharre@gmail.com", "MQPOSXIY", "https://thumbs.dreamstime.com/b/black-tycoon-avatar-flat-icon-white-series-afro-american-businessman-secret-agent-jacket-green-tie-95789619.jpg"));

        }

        public static StudentData GetInstance()
        {
            if (instance == null)
            {
                instance = new StudentData();
            }

            return instance;
        }

        
    }
}
