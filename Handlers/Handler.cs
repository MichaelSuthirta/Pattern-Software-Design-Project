using PSDLabProject.Models;
using PSDLabProject.Repositories;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Linq;
using System.Web;

namespace PSDLabProject.Handlers
{
    public class Handler
    {
        public static List<dynamic> getAllJewelList()
        {
            return JewelRepository.getAllJewels();
        } 
    }
}