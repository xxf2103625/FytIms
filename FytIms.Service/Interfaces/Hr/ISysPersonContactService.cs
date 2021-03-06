﻿using FytIms.Common.ClientData;
using FytIms.Service.Model.DtoModel;
using FytIms.Service.Model.PostModel;
using System.Threading.Tasks;

namespace FytIms.Service.Interfaces
{
    /// <summary>
    /// 员工信息扩展接口
    /// </summary>
    public interface ISysPersonContactService
    {
        /// <summary>
        /// 查询列表
        /// </summary>
        /// <returns></returns>
        Task<ApiResult<Page<SysPersonContactDto>>> GetPagesAsync(SysPersonContactPage parm);

        /// <summary>
        /// 获得一条数据
        /// </summary>
        /// <returns></returns>
        Task<ApiResult<SysPersonContactDto>> GetByGuidAsync(ByGuidPost parm);

        /// <summary>
        /// 添加一条数据
        /// </summary>
        /// <returns></returns>
        Task<ApiResult<string>> AddAsync(SysPersonContactPost parm);

        /// <summary>
        /// 删除一条或多条数据
        /// </summary>
        /// <returns></returns>
        Task<ApiResult<string>> DeleteAsync(DeletePost parm);

        /// <summary>
        /// 修改一条数据
        /// </summary>
        /// <returns></returns>
        Task<ApiResult<string>> ModifyAsync(SysPersonContactPost parm);
    }
}
