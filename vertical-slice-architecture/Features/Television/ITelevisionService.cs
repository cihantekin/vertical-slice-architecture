﻿namespace vertical_slice_architecture.Features.Television
{
    public interface ITelevisionService
    {
        Task<IEnumerable<Domain.Television>> GetTelevisionsForBrand(int brandId);
    }
}
