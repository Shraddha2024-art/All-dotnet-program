using System;
using System.Data;
using EduHub_Repository_Console_Project.Models;
 
namespace EduHub_Repository_Console_Project.Repository{
    internal interface IMaterialRepository{
        int AddCourseMaterialById(Material material);
        DataSet GetCourseMaterialById(int courseid);
        int UpdateMaterial(Material material);
    }
}