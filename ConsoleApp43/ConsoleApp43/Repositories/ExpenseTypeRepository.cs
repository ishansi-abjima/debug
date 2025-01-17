﻿//using Microsoft.EntityFrameworkCore;
//using ConsoleApp43;


//namespace ConsoleApp43
//{
//    public class ExpenseTypeRepository : IExpenseTypeRepository
//    {
//        private ProjectContext _projectContext;

//        public ExpenseTypeRepository(ProjectContext projectContext)
//        {
//            _projectContext = projectContext;
//        }

//        public IEnumerable<ExpenseTypeCategory> GetExpenseTypeCategories()
//        {
//            return _projectContext.ExpenseTypeCategories.AsNoTracking()
//                .OrderBy(x => x.ID)
//                .ToList();
//        }

//        public IEnumerable<ExpenseType> GetExpenseTypes()
//        {
//            return _projectContext.ExpenseTypes.AsNoTracking()
//                .OrderBy(x => x.ID)
//                .ToList();
//        }

//        public IEnumerable<ExpenseType> GetExpenseTypesByCategoryId(int categoryId)
//        {
//            return _projectContext.ExpenseTypes.AsNoTracking()
//                .Where(x => x.CategoryId == categoryId)
//                .OrderBy(x => x.ID)
//                .ToList();
//        }
//    }
//}
