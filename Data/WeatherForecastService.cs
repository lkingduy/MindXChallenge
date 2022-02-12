using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MindXChallenge.Data.Models;

namespace MindXChallenge.Data
{
    public class WeatherForecastService
    {
        public Task<Blog[]> GetUserBlogs(string userId)
        {
            MindxdbContext context = new MindxdbContext();
            return context.Blog.Where(x => x.UserId == userId).ToArrayAsync();
        }

        public Task<Blog[]> GetBlogs()
        {
            MindxdbContext context = new MindxdbContext();
            return context.Blog.ToArrayAsync();
        }

        public Blog GetBlog(int id)
        {
            MindxdbContext context = new MindxdbContext();
            return context.Blog.FirstOrDefault(x => x.Id == id);
        }

        public List<Comment> GetCommentByBlog(int blogId)
        {
            MindxdbContext context = new MindxdbContext();
            return context.Comment.Where(x => x.BlogId == blogId).ToList();
        }

        public void SaveLikeCount(int blogId)
        {
            MindxdbContext context = new MindxdbContext();
            var blog = context.Blog.FirstOrDefault(x => x.Id == blogId);
            blog.LikeCount = blog.LikeCount == null ? 1 : blog.LikeCount + 1;
            context.Blog.Update(blog);
            context.SaveChanges();
        }

        public bool CreateBlog(BlogData blogData)
        {
            MindxdbContext context = new MindxdbContext();
            Blog blog = new Blog()
            {
                Name = blogData.Name,
                Contents = blogData.Contents,
                UpdYmd = blogData.Time.ToString("yyyyMMdd"),
                UpdHms = blogData.Time.ToString("HHmm"),
                UserId = blogData.UserId,
                Tags = string.Join(",", blogData.Tags)
            };
            context.Blog.Add(blog);
            context.SaveChanges();
            return true;
        }

        public void SaveComment(string comment, string userId, int blogId)
        {
            MindxdbContext context = new MindxdbContext();
            var cmt = new MindXChallenge.Data.Comment() { 
                BlogId = blogId,
                Contents = comment,
                UserId = userId,
                UpdYmd = DateTime.Now.ToString("yyyyMMdd"),
                UpdHms = DateTime.Now.ToString("HHmm"),
            };
            context.Comment.Add(cmt);
            context.SaveChanges();
        }
    }
}
