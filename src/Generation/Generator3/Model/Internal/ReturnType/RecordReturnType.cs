﻿using Generator3.Converter;

namespace Generator3.Model.Internal
{
    public class RecordReturnType : ReturnType
    {
        private GirModel.Record Type => (GirModel.Record) Model.AnyType.AsT0;

        public override string NullableTypeName => IsPointer
            ? Type.GetFullyQualifiedInternalHandle()
            : Type.GetFullyQualifiedInternalStructName();

        protected internal RecordReturnType(GirModel.ReturnType returnValue) : base(returnValue)
        {
            returnValue.AnyType.VerifyType<GirModel.Record>();
        }
    }
}