﻿using MitalisBooks.DataAccess.Repository.IRepository;
using MitalisBooks.DataAccess.Repository;
using MitalisBookStore.DataAccess;
using MitalisBookStore.Areas;
using MitalisBookStore.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MitalisBooks.Models;
using MitalisBooks.Utility;
using Dapper;

namespace MitalisBookStore.Areas.Admin.Controllers
{
    [Area("Admin")]

    public class CoverTypeController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public CoverTypeController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            return View();
        }


        public IActionResult Upsert(int? id)        // action method for upsert
        {
            CoverType coverType = new CoverType();

            if (id == null)
            {
                //this is for create
                return View(coverType);
            }

            //this is for edit
            //coverType = _unitOfWork.CoverType.Get(id.GetValueOrDefault());

            var parameter = new DynamicParameters();
            parameter.Add("@Id", id);
            coverType = _unitOfWork.SP_Call.OneRecord<CoverType>(SD.Proc_CoverType_Get, parameter);
            if (coverType == null)
            {
                return NotFound();
            }

            return View(coverType);
        }


        // use HTTP POST to define the post-action method
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Upsert(CoverType coverType)
        {
            if (ModelState.IsValid)   // check all variables in the model (e.g. Name Required) to increase security
            {

                var parameter = new DynamicParameters();
                parameter.Add("@Name", coverType.Name);
                if (coverType.Id == 0)
                {
                    //_unitOfWork.CoverType.Add(coverType);
                    //_unitOfWork.save();
                    _unitOfWork.SP_Call.Execute(SD.Proc_CoverType_Create, parameter);
                }
                else
                {
                    // _unitOfWork.CoverType.Update(coverType);
                    parameter.Add("@Id", coverType.Id);
                    _unitOfWork.SP_Call.Execute(SD.Proc_CoverType_Update, parameter);
                }

                _unitOfWork.Save();
                return RedirectToAction(nameof(Index));     // to see all the categories
            }

            return View(coverType);
        }


        // API calls here for Delete
        #region API CALLS
        [HttpGet]
        public IActionResult GetAll()
        {
            // return NotFound();
            // var allObj = _unitOfWork.CoverType.GetAll();
            var allObj = _unitOfWork.SP_Call.List<CoverType>(SD.Proc_CoverType_GetAll, null);
            return Json(new { data = allObj });
        }


        [HttpDelete]
        public IActionResult Delete(int id)
        {
            //var objFromDb = _unitOfWork.CoverType.Get(id);
            var parameter = new DynamicParameters();
            parameter.Add("@Id", id);
            var objFromDb = _unitOfWork.SP_Call.OneRecord<CoverType>(SD.Proc_CoverType_Get, parameter);
            if (objFromDb == null)
            {
                return Json(new { success = false, message = "Error while deleting" });
            }
            //_unitOfWork.CoverType.Remove(objFromDb);
            _unitOfWork.SP_Call.Execute(SD.Proc_CoverType_Delete, parameter);
            _unitOfWork.Save();
            return Json(new { success = true, message = "Delete Successfully" });
        }
        #endregion
    }
}
