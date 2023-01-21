using LearnEntityFramework.API.Repositories.Common;
using LearnEntityFramework.EFLibrary.Data;
using LearnEntityFramework.EFLibrary.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace LearnEntityFramework.API.Repositories.Authentication
{
    public class UserRoleRepository : IBaseRepository<UserRoleEntity, int>
    {
        private readonly EFDataContext _context;


        public UserRoleRepository(EFDataContext context)
        {
            this._context = context;
        }

        public Task<bool> CreateAsync(UserRoleEntity entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(UserRoleEntity entity)
        {
            throw new NotImplementedException();
        }

        public Task<List<UserRoleEntity>> GetActiveAsync()
        {
            throw new NotImplementedException();
        }

        public Task<List<UserRoleEntity>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<UserRoleEntity?> GetByIdAsync(int key)
        {
            throw new NotImplementedException();
        }

        public Task<List<UserRoleEntity>> GetInActiveAsync()
        {
            throw new NotImplementedException();
        }

        public Task<bool> SoftDeleteAsync(UserRoleEntity entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateAsync(UserRoleEntity entity)
        {
            throw new NotImplementedException();
        }


        #region ============================================= START IMPLEMENTATION BASE REPOSITORY =================================================



        #endregion ============================================= END IMPLEMENTATION BASE REPOSITORY =================================================
    }
}

