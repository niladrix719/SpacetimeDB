﻿//HintName: TestDuplicateTableName.cs
// <auto-generated />
#nullable enable

partial struct TestDuplicateTableName
    : System.IEquatable<TestDuplicateTableName>,
        SpacetimeDB.BSATN.IStructuralReadWrite
{
    public void ReadFields(System.IO.BinaryReader reader) { }

    public void WriteFields(System.IO.BinaryWriter writer) { }

    object SpacetimeDB.BSATN.IStructuralReadWrite.GetSerializer()
    {
        return new BSATN();
    }

    public override string ToString() => $"TestDuplicateTableName {{  }}";

    public readonly partial struct BSATN : SpacetimeDB.BSATN.IReadWrite<TestDuplicateTableName>
    {
        public TestDuplicateTableName Read(System.IO.BinaryReader reader)
        {
            var ___result = new TestDuplicateTableName();
            ___result.ReadFields(reader);
            return ___result;
        }

        public void Write(System.IO.BinaryWriter writer, TestDuplicateTableName value)
        {
            value.WriteFields(writer);
        }

        public SpacetimeDB.BSATN.AlgebraicType.Ref GetAlgebraicType(
            SpacetimeDB.BSATN.ITypeRegistrar registrar
        ) =>
            registrar.RegisterType<TestDuplicateTableName>(
                _ => new SpacetimeDB.BSATN.AlgebraicType.Product(
                    new SpacetimeDB.BSATN.AggregateElement[] { }
                )
            );

        SpacetimeDB.BSATN.AlgebraicType SpacetimeDB.BSATN.IReadWrite<TestDuplicateTableName>.GetAlgebraicType(
            SpacetimeDB.BSATN.ITypeRegistrar registrar
        ) => GetAlgebraicType(registrar);
    }

    public override int GetHashCode()
    {
        return 0;
    }

#nullable enable
    public bool Equals(TestDuplicateTableName that)
    {
        return true;
    }

    public override bool Equals(object? that)
    {
        if (that == null)
        {
            return false;
        }
        var that_ = that as TestDuplicateTableName?;
        if (((object?)that_) == null)
        {
            return false;
        }
        return Equals(that_);
    }

    public static bool operator ==(TestDuplicateTableName this_, TestDuplicateTableName that)
    {
        if (((object?)this_) == null || ((object?)that) == null)
        {
            return object.Equals(this_, that);
        }
        return this_.Equals(that);
    }

    public static bool operator !=(TestDuplicateTableName this_, TestDuplicateTableName that)
    {
        if (((object?)this_) == null || ((object?)that) == null)
        {
            return !object.Equals(this_, that);
        }
        return !this_.Equals(that);
    }
#nullable restore
} // TestDuplicateTableName
