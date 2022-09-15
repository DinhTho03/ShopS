using ShopShoes.Model.HomePage;

namespace ShopShoes.IService.IBlog
{
    public interface IBlog
    {
        List<ListCategory> AllBlog(int CategoryId, int page = 1);
        List<ListCategory> RecentPost(int CategoryId);
        List<ListCategory> PopularPost(int CategoryId);
        List<ListCategory_User> PopularAuthor(int CategoryId);
        List<ListCategory> BlogDetail(int CategoryId, string ProductName);

    }
}
