﻿using BoooooJu.Service.Core.Contracts.Base;
using BoooooJu.Service.Core.Dal;
using System.ServiceModel;

namespace BoooooJu.Service.Core.Contracts
{
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码和配置文件中的接口名“IService1”。
    [ServiceContract]
    public interface ISetUser: IBaseSetData<User>
    { 
       
    } 
}
