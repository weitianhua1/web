using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeFirstNewDatabaseSample.Models;
using CodeFirstNewDatabaseSample.BusinessLayer;
using CodeFirstNewDatabaseSample.DataAccessLayer;
using CodeFirstNewDatabaseSample.BussinessLayer;

namespace CodeFirstNewDatabaseSample
{
    class Program
    {
        static void Main(string[] args)
        {
            // crateBlog();
            //querblog();
            //Update();
            QuerBlog();
            //Delete();
            //AddPost();
            DeletePost();
            Console.WriteLine("请按任意键退出");
            Console.ReadKey();

        }
        static void AddPost()
        {
            //显示博客列表
            QuerBlog();
            //用户选择某个博客（id）


            int blogId = GetBlogId();
            //Console.WriteLine(blogId);
            //显示指定博客的帖子列表
            DisplayPosts(blogId);
            //根据指定到博客信息创建新帖子   
            //新建贴子
            Post post = new Post();
            //填写贴子属性
            Console.WriteLine("请输入贴子标题");
            post.Title = Console.ReadLine();
            Console.WriteLine("请输入贴子内容");
            post.Content = Console.ReadLine();
            post.BlogId = blogId;
            //贴子通过数据库上下文新增
            using (var db = new BloggingContext())
            {
                db.Posts.Add(post);
                db.SaveChanges();
            }

            //显示指定博客的帖子列表
            DisplayPosts(blogId);
        }
        static int GetBlogId()
        {
            Console.WriteLine("请输入博客ID");

            int id = int.Parse(Console.ReadLine());
            //返回id
            return id;
        }
        static void DisplayPosts(int blogId)
        {
            Console.WriteLine(blogId + "的贴子列表");
            List<Post> list = null;
            //根据博客ID获取博客
            //BlogBusinessLayer bbl = new BlogBusinessLayer();
            //var blogs = bbl.Query();

            using (var db = new BloggingContext())
            {
                Blog blog = db.Blogs.Find(blogId);

                list = blog.Posts;
            }
            foreach(var item in list)
            {
                Console.WriteLine(item.Blog.BlogId + "--" + item.Title);
            }


  
        }
        static void crateBlog()
        {
            Console.WriteLine("请输入一个博客名称");
            string name = Console.ReadLine();
            Blog blog = new Blog();
            blog.Name = name;
            BlogBusinessLayer bbl = new BlogBusinessLayer();
            bbl.Add(blog);
        }
        static void QuerBlog()
        {
            BlogBusinessLayer bbl = new BlogBusinessLayer();
            var blogs = bbl.Query();
            foreach (var item in blogs)
            {
                Console.WriteLine(item.BlogId + "" + item.Name);
            }
        }
        static void Update()
        {
            Console.WriteLine("请输入id");
            int id = int.Parse(Console.ReadLine());
            BlogBusinessLayer bbl = new BlogBusinessLayer();
            Blog blog = bbl.Query(id);
            Console.WriteLine("请输入新名字");
            string name = Console.ReadLine();
            blog.Name = name;
            bbl.Update(blog);
        }

        //删除
        static void Delete()
        {
            BlogBusinessLayer bbl = new BlogBusinessLayer();
            Console.WriteLine("请输入id");
            int id = int.Parse(Console.ReadLine());
            Blog blog = bbl.Query(id);
            bbl.Delete(blog);
        }
        //删除贴子
        static void DeletePost()
        {
            QuerBlog();
            BlogBusinessLayer bbl = new BlogBusinessLayer();
            PostBussinessLayer pbl = new PostBussinessLayer();
            
            Console.WriteLine("请输入一个博客ID");
            int id = int.Parse(Console.ReadLine());
            DisplayPosts(id);
            Console.WriteLine("请输入删除的贴子");
            int postId = int.Parse(Console.ReadLine());
            Post post = pbl.QueryPost(postId);
            pbl.DeletePost(post);
            DisplayPosts(id);
        }

        //更新贴子
        static void UpdatePost()
        {
            QuerBlog();
            BlogBusinessLayer bbl = new BlogBusinessLayer();
            PostBussinessLayer pbl = new PostBussinessLayer();
            Console.WriteLine("请输入一个博客ID");
            int blogId = int.Parse(Console.ReadLine());
            DisplayPosts(blogId);
            Console.WriteLine("请输入修改的贴子ID");
            int postId = int.Parse(Console.ReadLine());
            Post post = pbl.QueryPost(postId);
            Console.WriteLine("请输入新标题");
            string newTitle = Console.ReadLine();
            post.Title = newTitle;
            Console.WriteLine("请输入新内容");
            string newContent = Console.ReadLine();
            post.Content = newContent;
            pbl.Update(post);
            DisplayPosts(blogId);
        }


    }
}
