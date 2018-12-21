﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeFirstNewDatabaseSample.Models;
using CodeFirstNewDatabaseSample.DataAccessLayer;
using System.Data.Entity;

namespace CodeFirstNewDatabaseSample.BussinessLayer
{
    public class PostBussinessLayer
    {
        public void Add(Post post)
        {
            //设置上下文生存期
            using (var db = new BloggingContext())
            {
                //向上下文Blogs数据集添加一个实体（改变实体状态为添加）
                db.Posts.Add(post);

                //或者将实体状态为添加

                //保存状态改变
                db.SaveChanges();
            }
        }
        public List<Post> QueryPost()
        {
            using (var db = new BloggingContext())
            {
                return db.Posts.ToList();
            }
        }
        public Post QueryPost(int id)
        {
            using (var db = new BloggingContext())
            {
                return db.Posts.Find(id);
            }
        }
        public void DeletePost(Post post)
        {
            using (var db = new BloggingContext())
            {
                db.Entry(post).State = EntityState.Deleted;

                db.SaveChanges();
            }
        }

        public void Update(Post post)
        {
            using (var db = new BloggingContext())
            {
                //修改博客实体状态
                db.Entry(post).State = EntityState.Modified;
                //保存状态
                db.SaveChanges();
            }
        }
    }
}