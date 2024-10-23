﻿using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;
using ThucTap_TuanKiet.Data;
using ThucTap_TuanKiet.Model;

namespace ThucTap_TuanKiet.Services
{
    public class AccountResponse : IAccount
    {
        private readonly ApplicationDBContext _context;
        private IConfiguration _configuration;

        public AccountResponse(ApplicationDBContext context, IConfiguration configuration)
        {
            _context = context;
            _configuration = configuration;
        }

        public Account AddUser(string fullName, string email, int? idPosition, string status)
        {
            try
            {
                var emailExit = _context.Accounts.FirstOrDefault(x => x.Email == email);
                if (emailExit != null)
                    return null;

                var account = new Account()
                {
                    FullName = fullName,
                    Email = email,
                    IdPosition = idPosition,
                    Status = status,
                    Role = "User",
                    Password = HashMD5("Add1123@")
                };

                _context.Accounts.Add(account);
                _context.SaveChanges();
                return account;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public Account GetAccount(int id)
        {
            return _context.Accounts.FirstOrDefault(x => x.IdAcc == id);
        }

        public string AccountList()
        {
            var accounts = _context.Accounts.Where(x => x.Role != "Owner").ToList();
            return JsonSerializer.Serialize(accounts);
        }

        public Account UpdateUser(int id, string fullName, string email, int? idPosition, string status)
        {
            try
            {
                var emailExit = _context.Accounts.FirstOrDefault(x => x.Email == email && x.IdAcc != id);
                if (emailExit != null)
                    return null;

                var us = _context.Accounts.Find(id);
                if (us == null)
                    return null;

                us.FullName = fullName;
                us.Email = email;
                us.IdPosition = idPosition;
                us.Status = status;

                _context.SaveChanges();
                return us;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public Account AddSale(string fullName, string email, int idPosition, int idManager, string status)
        {
            try
            {
                var acc = new Account()
                {
                    FullName = fullName,
                    Email = email,
                    IdPosition = idPosition,
                    IdManager = idManager,
                    Role = "Admin",
                    Status = status,
                    Password = HashMD5("Add1123@")
                };

                _context.Accounts.Add(acc);
                _context.SaveChanges();
                return acc;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public Account UpdateSale(int id, string fullName, string email, int idPosition, int idManager, int? idDistributor, string status)
        {
            try
            {
                var mailExist = _context.Accounts.FirstOrDefault(x => x.Email == email && x.IdAcc != id);
                if (mailExist != null)
                    return null;

                var acc = _context.Accounts.Find(id);
                if (acc == null)
                    return null;

                acc.FullName = fullName;
                acc.Email = email;
                acc.IdPosition = idPosition;
                acc.IdManager = idManager;
                acc.IdDis = idDistributor;
                acc.Status = status;

                _context.SaveChanges();
                return acc;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public string Delete(int id)
        {
            try
            {
                var acc = _context.Accounts.Find(id);
                if (acc == null)
                    return "Not found";

                _context.Accounts.Remove(acc);
                _context.SaveChanges();
                return "Delete Success";
            }
            catch (Exception)
            {
                return "Cannot remove";
            }
        }

        public Account AddSubordinate(int idAccount, int idManager)
        {
            try
            {
                var acc = _context.Accounts.Find(idAccount);
                if (acc == null)
                    return null;

                acc.IdManager = idManager;
                _context.SaveChanges();
                return acc;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public Account DeleteSubordinate(int idAccount)
        {
            try
            {
                var acc = _context.Accounts.Find(idAccount);
                if (acc == null)
                    return null;

                acc.IdManager = null;
                _context.SaveChanges();
                return acc;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public Account UpdateYourInfo(int id, string fullName, string phone, string address)
        {
            try
            {
                if (!IsValidPhone(phone))
                    return null;

                var acc = _context.Accounts.Find(id);
                if (acc == null)
                    return null;

                acc.FullName = fullName;
                acc.Phone = phone;
                acc.Address = address;

                _context.SaveChanges();
                return acc;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public bool IsValidPhone(string phone)
        {
            string pattern = @"^(?:\+84|0)(?:3[2-9]|5[6|8|9]|7[0|6-9]|8[1-5]|9[0-9]|2[0-9]{1})\d{7}$";
            Regex regex = new Regex(pattern);
            return regex.IsMatch(phone);
        }

        public string HashMD5(string password)
        {
            MD5 md5 = MD5.Create();
            byte[] passBytes = Encoding.UTF8.GetBytes(password);
            byte[] hashBytes = md5.ComputeHash(passBytes);
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < hashBytes.Length; i++)
            {
                builder.Append(hashBytes[i].ToString("x2"));
            }
            return builder.ToString();
        }

        public Task AccountListAsync()
        {
            throw new NotImplementedException();
        }
    }
}
