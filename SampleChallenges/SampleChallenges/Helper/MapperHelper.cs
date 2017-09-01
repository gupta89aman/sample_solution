using AutoMapper;
using SampleChallenges.Models;
using SampleDataContext.DBClasses;
using System.Collections.Generic;

namespace SampleChallenges.Helper
{
    public static class MapperHelper
    {
        public static void SetUp()
        {
            Mapper.CreateMap<Question, QuestionModel>().ForMember(member=>member.QuestionCategory,
                action=>action.MapFrom(source=>source.QuestionCategory));
            //Mapper.CreateMap<List<Question>, List<QuestionModel>>();
            Mapper.CreateMap<QuestionModel, SampleDataContext.DBClasses.Question>();

            Mapper.CreateMap<SampleDataContext.DBClasses.QuestionCategory, SampleChallenges.Models.QuestionCategoryModel>().
                ForMember(member=>member.QuestionCategoryName,action=>action.MapFrom(source=>source.QuestionCategoryName));
            Mapper.CreateMap<SampleChallenges.Models.QuestionCategoryModel, SampleDataContext.DBClasses.QuestionCategory>().
                ForMember(member => member.QuestionCategoryName, action => action.MapFrom(source => source.QuestionCategoryName));

            Mapper.CreateMap<QuestionCategory,QuestionCategoryModel>();
            Mapper.CreateMap<QuestionCategoryModel,QuestionCategory>();
        }
    }
}