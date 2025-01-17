﻿using Zuri_Portfolio_Explore.Domains.DTOs;
using Zuri_Portfolio_Explore.Domains.DTOs.Request;
using Zuri_Portfolio_Explore.Domains.DTOs.Response;

namespace Zuri_Portfolio_Explore.Repository.Interfaces
{
    public interface IPortfolioService
    {
        Task<ApiResponse<List<PortfolioResponse>>> GetAllPortfolios();
        Task<ApiResponse<List<PortfolioResponse>>> GetByFilterPortfolios(PortfolioFilterDTO portfolioFilterDTO);
        Task<ApiResponse<List<PortfolioResponse>>> GetPortfoliosBySearchTerm(string searchTerm);
    }
}
