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
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

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

        public bool CreateBlog(BlogData blogData)
        {
            MindxdbContext context = new MindxdbContext();
            Blog blog = new Blog()
            {
                Name = blogData.Name,
                Contents = blogData.Contents,
                UpdYmd = blogData.Time.ToString("yyyyMMdd"),
                UpdHms = blogData.Time.ToString("HHmm"),
                UserId = blogData.UserId
            };
            context.Blog.Add(blog);
            context.SaveChanges();
            return true;
        }
    }
}
