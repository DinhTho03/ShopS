using Microsoft.AspNetCore.Mvc;
using ShopShoes.Data;
using ShopShoes.Data.DetailPage_Description.DetailPage;
using ShopShoes.IService.IBlog;
using ShopShoes.Model;
using ShopShoes.Model.HomePage;
using ShopShoes.Model.Paging;

namespace ShopShoes.Service.Blog
{
    public class BlogResposity : IBlog
    {
        private readonly ShopDbContext _shopDbContext;
        public static int page_size { get; set; } = 6;
        public BlogResposity(ShopDbContext shopDbContext)
        {
            _shopDbContext = shopDbContext;
        }
        public List<ListCategory> AllBlog(int CategoryId, int page)
        {
            var blogs = from blog in _shopDbContext.products
                        where blog.CateId == CategoryId
                        select new ListCategory
                        {
                            Image = blog.ProductImages.Select(x => new ProductImageModel
                            {
                                FeatureImage = x.FeatureImage
                            }).Take(1).ToList(),
                            Description = blog.Description,
                            Style = blog.Style,
                            Tilte = blog.Title,
                            User = blog.userInfos.Select(x => new ListCategory_User
                            {
                                Avatar = x.Avatar,
                                OrderBy = x.CommentDate,
                                UserName = x.UserName
                            }).ToList()
                        };
            var result = PaginatedList<ListCategory>.Create(blogs, page, page_size);
            return result;
        }

        public List<ListCategory_User> PopularAuthor(int CategoryId)
        {

            var blogs = from blog in _shopDbContext.userInfos
                        orderby blog.Articles.Value descending
                        select new ListCategory_User
                        {
                            Avatar = blog.Avatar,
                            UserName = blog.UserName,
                            OrderBy = blog.CommentDate
                        };
            return blogs.Take(3).ToList();
        }

        public List<ListCategory> PopularPost(int CategoryId)
        {

            var blogs = from blog in _shopDbContext.products
                        where blog.CateId == CategoryId
                        orderby blog.userInfos.FirstOrDefault().Articles.Value descending
                        select new ListCategory
                        {

                            Description = blog.Description,
                            User = blog.userInfos.Select(x => new ListCategory_User
                            {
                                OrderBy = x.CommentDate,
                            }).ToList()
                        };
            return blogs.Take(3).ToList();
        }

        public List<ListCategory> RecentPost(int CategoryId)
        {

            var blogs = from blog in _shopDbContext.products
                        where blog.CateId == CategoryId
                        orderby blog.CreateAt descending
                        select new ListCategory
                        {
                            Image = blog.ProductImages.Select(x => new ProductImageModel
                            {
                                FeatureImage = x.FeatureImage
                            }).Take(1).ToList(),
                            Description = blog.Description,
                            User = blog.userInfos.Select(x => new ListCategory_User
                            {
                                OrderBy = x.CommentDate
                            }).ToList()
                        };
            return blogs.Take(4).ToList();
        }
        public List<ListCategory> BlogDetail(int CategoryId, string ProductName)
        {
            var blogs = (from blog in _shopDbContext.products
                         where blog.CateId == CategoryId && blog.ProductName == ProductName
                         select new ListCategory
                         {
                             Image = blog.ProductImages.Select(x => new ProductImageModel
                             {
                                 FeatureImage = x.FeatureImage
                             }).Take(4).ToList(),
                             Description = blog.Description,
                             Style = blog.Style,
                             Tilte = blog.Title,
                             User = blog.userInfos.Select(x => new ListCategory_User
                             {
                                 Avatar = x.Avatar,
                                 OrderBy = x.CommentDate,
                                 UserName = x.UserName
                             }).ToList()
                         }).Take(1);
            return blogs.ToList();
        }

    }
}
