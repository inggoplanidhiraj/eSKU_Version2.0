
using Common.APAC.eSKU.Common.DAL.RepositoryContracts;
using Common.APAC.eSKU.Common.Entities;

namespace Common.APAC.eSKU.Common.DAL.Repositories
{
    public class VersionCodeRepository : Repository<VersionCode>, IVersionCodeRepository

    {
        public VersionCodeRepository(eSKUContext eSKUcontext) : base(eSKUcontext)
        {
        }

        public eSKUContext eSKUcontext
        {
            get { return Context as eSKUContext; }
        }
    }

}
