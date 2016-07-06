using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoooooJu.Service.DPModels.OBModels;
using Dapper;
using BoooooJu.Service.DPModels;
using BoooooJu.Service.ICore.GoodsModule;

namespace BoooooJu.Service.DPCore.GoodsModule
{
    public class GoodsService : IQueryService
    {
        public Goods FindGoodsById(int id)
        {
            return Base.BaseAction<Goods>.FindById(id, "Goods");
        }
        public OBGoods FindGoodsInfoById(int id)
        {
            OBGoods result = null;
            Func<OBGoods, Goods_Style, Goods_Size, OBGoods> dg = delegate (OBGoods goods, Goods_Style style, Goods_Size size)
                {
                    if (result == null)
                    {
                        result = goods;
                    }
                    if (style != null)
                    {
                        result.Styles.Add(style);
                    }
                    if (size != null)
                    {
                        result.Sizes.Add(size);
                    }
                    return result;
                };
            string sqlCmdText = @"SELECT * FROM [Goods] LEFT JOIN [Goods_Size] ON [Goods].Id=[Goods_Size].GoodsId LEFT JOIN [Goods_Style] ON [Goods].Id=[Goods_Style].GoodsId WHERE [Goods].Id=@Id";
            using (var conn = DBHelper.OpenConnection())
            {
                conn.Query(sqlCmdText.ToString(), dg, new { Id = id });
            }
            return result;
        }
    }
}
