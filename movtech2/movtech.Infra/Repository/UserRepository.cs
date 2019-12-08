using movtech.Domain.Entities;
using movtech.Domain.Interfaces.Repository;
using movtech.Infra.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;

namespace movtech.Infra.Repository
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        private new readonly MovtechContext _context;

        public UserRepository(MovtechContext context) : base(context)
        {
            _context = context;
        }

        public User Register(User user)
        {
            //user.Password = HashPassword(user.Password);
            _context.Users.Add(user);
            _context.SaveChanges();

            return user;
        }

        public User Login(string cpf, string password)
        {
            return  _context.Users.Where(u => u.CPF == cpf && u.Password == password).FirstOrDefault();            
        }

        //private string HashPassword(string password)
        //{
        //    // generate a 128-bit salt using a secure PRNG
        //    byte[] salt = new byte[128 / 8];
        //    using (var rng = RandomNumberGenerator.Create())
        //    {
        //        rng.GetBytes(salt);
        //    }

        //    // derive a 256-bit subkey (use HMACSHA1 with 10,000 iterations)
        //    string hashed = Convert.ToBase64String(KeyDerivation.Pbkdf2(
        //        password: password,
        //        salt: salt,
        //        prf: KeyDerivationPrf.HMACSHA1,
        //        iterationCount: 10000,
        //        numBytesRequested: 256 / 8));

        //    return hashed;
        //}

    }
}
