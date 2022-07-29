﻿using OnlineHotelManagementAPI.Models;

namespace OnlineHotelManagementAPI.Repositories
{
    public class StaffRepo : IStaff
    {
        private HotelContext _context;

        public StaffRepo(HotelContext context)
        {
            _context = context;
        }

        #region DeleteStaff
        public string DeleteStaff(int Id)
        {
            string stcode = string.Empty;
            try
            {
                var staff = _context.Staffs.Find(Id);
                if (staff != null)
                {
                    _context.Staffs.Remove(staff);
                    _context.SaveChanges();
                    stcode = "200";
                }
                else
                {
                    stcode = "400";
                }
            }
            catch
            {
                stcode = "400";
            }
            return stcode;
        }
        #endregion

        #region GetAllStaff
        public List<Staff> GetAllStaff()
        {
            try
            {
                List<Staff> staff = _context.Staffs.ToList();
                return staff;
            }
            catch
            {
                throw;
            }
        }
        #endregion

        #region GetStaffById
        public string GetStaffById(int id)
        {
            string stcode = string.Empty;
            try
            {
                Staff staff = _context.Staffs.Find(id);
                if (staff != null)
                {
                    _context.SaveChanges();
                    stcode = "200";
                }
                else
                {
                    stcode = "400";
                }

            }
            catch (Exception e)
            {
                stcode = e.Message;
            }
            return stcode;
        }
        #endregion

        #region InsertStaff
        public string InsertStaff(Staff staff)
        {
            string stcode = string.Empty;
            try
            {
                _context.Staffs.Add(staff);
                _context.SaveChanges();
                stcode = "200";

            }
            catch (Exception e)
            {
                stcode = "400";
            }
            return stcode;

        }
        #endregion

        #region SaveStaff
        public void SaveStaff(Staff staff)
        {
            _context.SaveChanges();
        }
        #endregion

        #region UpdateStaff
        public string UpdateStaff(Staff staff)
        {
            string stcode = string.Empty;
            try
            {
                _context.Staffs.Update(staff);
                _context.SaveChanges();
                stcode = "200";

            }
            catch (Exception e)
            {
                stcode = "400";
            }
            return stcode;
        }
        #endregion
    }
}
