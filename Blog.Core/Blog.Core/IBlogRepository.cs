using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Core
{
    interface IBlogRepository
    {
        public interface IBlogRepository
        {
            IList<Post> Posts(int pageNo, int pageSize);
            int TotalPosts();
        }
    }
}
