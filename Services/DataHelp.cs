﻿using Services.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Caching;

namespace Services
{
    public class DataHelp
    {
         //获取用户信息
        public static User GetUserByAccount(string account)
        {
            User user = new User();
            return user;
        }
        //获取用户题目和答案
        public static List<UserAnswer> GetUserAnswer(string userId)
        {
            List<UserAnswer> userAnswerList = new List<UserAnswer>();
            return userAnswerList;
        }
        //获取用户登录提交和得分情况
        public static UserScoreModel GetUserScore(string userId)
        {
            UserScoreModel model = new UserScoreModel();
            return model;
        }
        public static List<QuestionEntity> GetQuestionList()
        {
            List<QuestionEntity> list = new List<QuestionEntity>();
            Cache cache = HttpRuntime.Cache;
            if (cache["Keys"] == null)
            {
                cache.Insert("Keys", list);
            }
            {
                list = cache["Keys"] as List<QuestionEntity>;
            }
            return list;
        }
    }
}
