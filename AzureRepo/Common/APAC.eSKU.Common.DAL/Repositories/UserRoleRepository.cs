


using Common.APAC.eSKU.Common.DAL.RepositoryContracts;
using Common.APAC.eSKU.Common.Entities;

namespace Common.APAC.eSKU.Common.DAL.Repositories
{
    public class UserRoleRepository : Repository<UserRole>, IUserRoleRepository

    {
        public UserRoleRepository(eSKUContext eSKUcontext) : base(eSKUcontext)
        {
        }

        public eSKUContext eSKUcontext
        {
            get { return Context as eSKUContext; }
        }
    }

}
