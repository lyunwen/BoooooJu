using BoooooJu.Service.DPModels;
using BoooooJu.Service.DPModels.OBModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoooooJu.Service.ICore.GoodsModule
{
    public interface IQueryService
    {
        OBGoods FindGoodsInfoById(int id);
        Goods FindGoodsById(int id);
    }
}