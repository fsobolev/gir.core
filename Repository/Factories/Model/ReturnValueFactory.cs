﻿using Repository.Model;
using Repository.Services;
using Repository.Xml;

namespace Repository.Factories
{
    public interface IReturnValueFactory
    {
        ReturnValue Create(ReturnValueInfo returnValueInfo);
    }

    public class ReturnValueFactory : IReturnValueFactory
    {
        private readonly ISymbolReferenceFactory _symbolReferenceFactory;
        private readonly ITransferFactory _transferFactory;

        public ReturnValueFactory(ISymbolReferenceFactory symbolReferenceFactory, ITransferFactory transferFactory)
        {
            _symbolReferenceFactory = symbolReferenceFactory;
            _transferFactory = transferFactory;
        }
        
        public ReturnValue Create(ReturnValueInfo returnValueInfo)
        {
            return new ReturnValue(
                symbolReference: _symbolReferenceFactory.Create(returnValueInfo),
                transfer: _transferFactory.FromText(returnValueInfo.TransferOwnership),
                nullable: returnValueInfo.Nullable
            );
        }
    }
}
