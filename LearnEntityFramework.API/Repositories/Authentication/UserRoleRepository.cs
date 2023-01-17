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


        #region ============================================= START IMPLEMENTATION BASE REPOSITORY =================================================

        public async Task<bool> CreateAsync(UserRoleEntity roleUser)
        {

            if(roleUser is null)
                return false;


            await _context.AddAsync(roleUser);
            await _context.SaveChangesAsync();

            return true;

        }

        public async Task<bool> DeleteAsync(UserRoleEntity entity)
        {
            if (entity is null)
                return false;

            _context.Remove<UserRoleEntity>(entity);
            await _context.SaveChangesAsync();

            return true;
        }

        public Task<List<UserRoleEntity>> GetActiveAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<List<UserRoleEntity>> GetAllAsync()
        {
            var result = from a in _context.UserRoles
                         select a;

            return await result.ToListAsync();
        }

        public async Task<UserRoleEntity?> GetByIdAsync(int key)
        {
            return await _context.UserRoles.Where(p => p.Id == key).SingleOrDefaultAsync();
        }

        public Task<List<UserRoleEntity>> GetInActiveAsync()
        {
            throw new NotImplementedException();
        }

        public Task<bool> SoftDeleteAsync(UserRoleEntity entity)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> UpdateAsync(UserRoleEntity entity)
        {
            if (entity is null)
                return false;

            _context.Update<UserRoleEntity>(entity);
            await _context.SaveChangesAsync();

            return true;
        }

        #endregion ============================================= END IMPLEMENTATION BASE REPOSITORY =================================================
    }
}

