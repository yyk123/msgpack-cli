﻿//------------------------------------------------------------------------------
// <auto-generated>
//     このコードはツールによって生成されました。
//     ランタイム バージョン:4.0.30319.34011
//
//     このファイルへの変更は、以下の状況下で不正な動作の原因になったり、
//     コードが再生成されるときに損失したりします。
// </auto-generated>
//------------------------------------------------------------------------------

namespace MsgPack.Serialization.GeneratedSerializers.MapBased {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("MsgPack.Serialization.CodeDomSerializers.CodeDomSerializerBuilder", "0.5.0.0")]
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public class MsgPack_Serialization_ComplexTypeWithDataContractSerializer : MsgPack.Serialization.MessagePackSerializer<MsgPack.Serialization.ComplexTypeWithDataContract> {
        
        private MsgPack.Serialization.MessagePackSerializer<object[]> _serializer0;
        
        private MsgPack.Serialization.MessagePackSerializer<object> _serializer1;
        
        private MsgPack.Serialization.MessagePackSerializer<object[][]> _serializer2;
        
        private MsgPack.Serialization.MessagePackSerializer<System.DateTime[]> _serializer3;
        
        private MsgPack.Serialization.MessagePackSerializer<System.Nullable<System.DateTime>> _serializer4;
        
        private MsgPack.Serialization.MessagePackSerializer<System.DateTime[][]> _serializer5;
        
        private MsgPack.Serialization.MessagePackSerializer<System.DateTime> _serializer6;
        
        private MsgPack.Serialization.MessagePackSerializer<MsgPack.MessagePackObject[]> _serializer7;
        
        private MsgPack.Serialization.MessagePackSerializer<MsgPack.MessagePackObject[][]> _serializer8;
        
        private MsgPack.Serialization.MessagePackSerializer<MsgPack.MessagePackObject> _serializer9;
        
        private MsgPack.Serialization.MessagePackSerializer<int[]> _serializer10;
        
        private MsgPack.Serialization.MessagePackSerializer<int[][]> _serializer11;
        
        private MsgPack.Serialization.MessagePackSerializer<int> _serializer12;
        
        private MsgPack.Serialization.MessagePackSerializer<string> _serializer13;
        
        private MsgPack.Serialization.MessagePackSerializer<System.Uri> _serializer14;
        
        private MsgPack.Serialization.MessagePackSerializer<byte[]> _serializer15;
        
        private MsgPack.Serialization.MessagePackSerializer<System.Collections.Generic.Dictionary<System.DateTime, string>> _serializer16;
        
        private MsgPack.Serialization.MessagePackSerializer<MsgPack.Serialization.AddOnlyCollection<System.DateTime>> _serializer17;
        
        private MsgPack.Serialization.MessagePackSerializer<MsgPack.Serialization.AddOnlyCollection<MsgPack.MessagePackObject>> _serializer18;
        
        private MsgPack.Serialization.MessagePackSerializer<MsgPack.Serialization.AddOnlyCollection<object>> _serializer19;
        
        private MsgPack.Serialization.MessagePackSerializer<System.Collections.ArrayList> _serializer20;
        
        private MsgPack.Serialization.MessagePackSerializer<System.ArraySegment<byte>> _serializer21;
        
        private MsgPack.Serialization.MessagePackSerializer<System.ArraySegment<decimal>> _serializer22;
        
        private MsgPack.Serialization.MessagePackSerializer<System.ArraySegment<int>> _serializer23;
        
        private MsgPack.Serialization.MessagePackSerializer<System.Numerics.BigInteger> _serializer24;
        
        private MsgPack.Serialization.MessagePackSerializer<byte> _serializer25;
        
        private MsgPack.Serialization.MessagePackSerializer<char[]> _serializer26;
        
        private MsgPack.Serialization.MessagePackSerializer<char> _serializer27;
        
        private MsgPack.Serialization.MessagePackSerializer<System.Collections.ObjectModel.Collection<MsgPack.MessagePackObject>> _serializer28;
        
        private MsgPack.Serialization.MessagePackSerializer<System.Collections.ObjectModel.Collection<System.DateTime>> _serializer29;
        
        private MsgPack.Serialization.MessagePackSerializer<System.Collections.ObjectModel.Collection<object>> _serializer30;
        
        private MsgPack.Serialization.MessagePackSerializer<System.Numerics.Complex> _serializer31;
        
        private MsgPack.Serialization.MessagePackSerializer<System.DateTimeOffset> _serializer32;
        
        private MsgPack.Serialization.MessagePackSerializer<decimal> _serializer33;
        
        private MsgPack.Serialization.MessagePackSerializer<System.Collections.Generic.Dictionary<MsgPack.MessagePackObject, MsgPack.MessagePackObject>> _serializer34;
        
        private MsgPack.Serialization.MessagePackSerializer<System.Collections.DictionaryEntry> _serializer35;
        
        private MsgPack.Serialization.MessagePackSerializer<System.Collections.Generic.Dictionary<object, object>> _serializer36;
        
        private MsgPack.Serialization.MessagePackSerializer<System.Collections.Generic.Dictionary<string, System.DateTime>> _serializer37;
        
        private MsgPack.Serialization.MessagePackSerializer<bool> _serializer38;
        
        private MsgPack.Serialization.MessagePackSerializer<System.Runtime.InteropServices.ComTypes.FILETIME> _serializer39;
        
        private MsgPack.Serialization.MessagePackSerializer<System.Guid> _serializer40;
        
        private MsgPack.Serialization.MessagePackSerializer<System.Collections.Generic.HashSet<MsgPack.MessagePackObject>> _serializer41;
        
        private MsgPack.Serialization.MessagePackSerializer<System.Collections.Generic.HashSet<System.DateTime>> _serializer42;
        
        private MsgPack.Serialization.MessagePackSerializer<System.Collections.Generic.HashSet<object>> _serializer43;
        
        private MsgPack.Serialization.MessagePackSerializer<System.Collections.Hashtable> _serializer44;
        
        private MsgPack.Serialization.MessagePackSerializer<System.Collections.Generic.ICollection<MsgPack.MessagePackObject>> _serializer45;
        
        private MsgPack.Serialization.MessagePackSerializer<System.Collections.Generic.ICollection<System.DateTime>> _serializer46;
        
        private MsgPack.Serialization.MessagePackSerializer<System.Collections.Generic.ICollection<object>> _serializer47;
        
        private MsgPack.Serialization.MessagePackSerializer<System.Collections.Generic.IDictionary<MsgPack.MessagePackObject, MsgPack.MessagePackObject>> _serializer48;
        
        private MsgPack.Serialization.MessagePackSerializer<System.Collections.Generic.IDictionary<object, object>> _serializer49;
        
        private MsgPack.Serialization.MessagePackSerializer<System.Collections.Generic.IDictionary<string, System.DateTime>> _serializer50;
        
        private MsgPack.Serialization.MessagePackSerializer<System.Collections.Generic.IList<MsgPack.MessagePackObject>> _serializer51;
        
        private MsgPack.Serialization.MessagePackSerializer<System.Collections.Generic.IList<System.DateTime>> _serializer52;
        
        private MsgPack.Serialization.MessagePackSerializer<System.Collections.Generic.IList<object>> _serializer53;
        
        private MsgPack.Serialization.MessagePackSerializer<MsgPack.Image> _serializer54;
        
        private MsgPack.Serialization.MessagePackSerializer<System.Collections.Generic.ISet<MsgPack.MessagePackObject>> _serializer55;
        
        private MsgPack.Serialization.MessagePackSerializer<System.Collections.Generic.ISet<System.DateTime>> _serializer56;
        
        private MsgPack.Serialization.MessagePackSerializer<System.Collections.Generic.ISet<object>> _serializer57;
        
        private MsgPack.Serialization.MessagePackSerializer<System.Collections.Generic.KeyValuePair<string, System.Numerics.Complex>> _serializer58;
        
        private MsgPack.Serialization.MessagePackSerializer<System.Collections.Generic.KeyValuePair<string, System.DateTimeOffset>> _serializer59;
        
        private MsgPack.Serialization.MessagePackSerializer<System.Collections.Generic.List<MsgPack.MessagePackObject>> _serializer60;
        
        private MsgPack.Serialization.MessagePackSerializer<System.Collections.Generic.List<System.DateTime>> _serializer61;
        
        private MsgPack.Serialization.MessagePackSerializer<System.Collections.Generic.List<object>> _serializer62;
        
        private MsgPack.Serialization.MessagePackSerializer<long> _serializer63;
        
        private MsgPack.Serialization.MessagePackSerializer<ushort> _serializer64;
        
        private MsgPack.Serialization.MessagePackSerializer<System.Collections.ObjectModel.ObservableCollection<MsgPack.MessagePackObject>> _serializer65;
        
        private MsgPack.Serialization.MessagePackSerializer<System.Collections.ObjectModel.ObservableCollection<System.DateTime>> _serializer66;
        
        private MsgPack.Serialization.MessagePackSerializer<System.Collections.ObjectModel.ObservableCollection<object>> _serializer67;
        
        private MsgPack.Serialization.MessagePackSerializer<MsgPack.Serialization.StringKeyedCollection<System.DateTime>> _serializer68;
        
        private MsgPack.Serialization.MessagePackSerializer<MsgPack.Serialization.StringKeyedCollection<MsgPack.MessagePackObject>> _serializer69;
        
        private MsgPack.Serialization.MessagePackSerializer<MsgPack.Serialization.StringKeyedCollection<object>> _serializer70;
        
        private MsgPack.Serialization.MessagePackSerializer<System.TimeSpan> _serializer71;
        
        private MsgPack.Serialization.MessagePackSerializer<System.Tuple<int, string, MsgPack.MessagePackObject, object>> _serializer72;
        
        private MsgPack.Serialization.MessagePackSerializer<System.Version> _serializer73;
        
        private MsgPack.Serialization.MessagePackSerializer<System.Nullable<System.ArraySegment<byte>>> _serializer74;
        
        private MsgPack.Serialization.MessagePackSerializer<System.Nullable<System.ArraySegment<decimal>>> _serializer75;
        
        private MsgPack.Serialization.MessagePackSerializer<System.Nullable<System.ArraySegment<int>>> _serializer76;
        
        private MsgPack.Serialization.MessagePackSerializer<System.Nullable<System.Numerics.BigInteger>> _serializer77;
        
        private MsgPack.Serialization.MessagePackSerializer<System.Nullable<char>> _serializer78;
        
        private MsgPack.Serialization.MessagePackSerializer<System.Nullable<System.Numerics.Complex>> _serializer79;
        
        private MsgPack.Serialization.MessagePackSerializer<System.Nullable<System.DateTimeOffset>> _serializer80;
        
        private MsgPack.Serialization.MessagePackSerializer<System.Nullable<decimal>> _serializer81;
        
        private MsgPack.Serialization.MessagePackSerializer<System.Nullable<System.Collections.DictionaryEntry>> _serializer82;
        
        private MsgPack.Serialization.MessagePackSerializer<System.Nullable<System.Runtime.InteropServices.ComTypes.FILETIME>> _serializer83;
        
        private MsgPack.Serialization.MessagePackSerializer<System.Nullable<System.Guid>> _serializer84;
        
        private MsgPack.Serialization.MessagePackSerializer<System.Nullable<System.Collections.Generic.KeyValuePair<string, System.Numerics.Complex>>> _serializer85;
        
        private MsgPack.Serialization.MessagePackSerializer<System.Nullable<System.Collections.Generic.KeyValuePair<string, System.DateTimeOffset>>> _serializer86;
        
        private MsgPack.Serialization.MessagePackSerializer<System.Nullable<System.TimeSpan>> _serializer87;
        
        private MsgPack.Serialization.MessagePackSerializer<MsgPack.Serialization.ComplexTypeGenerated> _serializer88;
        
        public MsgPack_Serialization_ComplexTypeWithDataContractSerializer(MsgPack.Serialization.SerializationContext context) : 
                base(MsgPack_Serialization_ComplexTypeWithDataContractSerializer.@__Conditional((context != null), context, MsgPack.Serialization.SerializationContext.Default).CompatibilityOptions.PackerCompatibilityOptions) {
            MsgPack.Serialization.SerializationContext safeContext = MsgPack_Serialization_ComplexTypeWithDataContractSerializer.@__Conditional((context != null), context, MsgPack.Serialization.SerializationContext.Default);
            this._serializer0 = safeContext.GetSerializer<object[]>();
            this._serializer1 = safeContext.GetSerializer<object>();
            this._serializer2 = safeContext.GetSerializer<object[][]>();
            this._serializer3 = safeContext.GetSerializer<System.DateTime[]>();
            this._serializer4 = safeContext.GetSerializer<System.Nullable<System.DateTime>>();
            this._serializer5 = safeContext.GetSerializer<System.DateTime[][]>();
            this._serializer6 = safeContext.GetSerializer<System.DateTime>();
            this._serializer7 = safeContext.GetSerializer<MsgPack.MessagePackObject[]>();
            this._serializer8 = safeContext.GetSerializer<MsgPack.MessagePackObject[][]>();
            this._serializer9 = safeContext.GetSerializer<MsgPack.MessagePackObject>();
            this._serializer10 = safeContext.GetSerializer<int[]>();
            this._serializer11 = safeContext.GetSerializer<int[][]>();
            this._serializer12 = safeContext.GetSerializer<int>();
            this._serializer13 = safeContext.GetSerializer<string>();
            this._serializer14 = safeContext.GetSerializer<System.Uri>();
            this._serializer15 = safeContext.GetSerializer<byte[]>();
            this._serializer16 = safeContext.GetSerializer<System.Collections.Generic.Dictionary<System.DateTime, string>>();
            this._serializer17 = safeContext.GetSerializer<MsgPack.Serialization.AddOnlyCollection<System.DateTime>>();
            this._serializer18 = safeContext.GetSerializer<MsgPack.Serialization.AddOnlyCollection<MsgPack.MessagePackObject>>();
            this._serializer19 = safeContext.GetSerializer<MsgPack.Serialization.AddOnlyCollection<object>>();
            this._serializer20 = safeContext.GetSerializer<System.Collections.ArrayList>();
            this._serializer21 = safeContext.GetSerializer<System.ArraySegment<byte>>();
            this._serializer22 = safeContext.GetSerializer<System.ArraySegment<decimal>>();
            this._serializer23 = safeContext.GetSerializer<System.ArraySegment<int>>();
            this._serializer24 = safeContext.GetSerializer<System.Numerics.BigInteger>();
            this._serializer25 = safeContext.GetSerializer<byte>();
            this._serializer26 = safeContext.GetSerializer<char[]>();
            this._serializer27 = safeContext.GetSerializer<char>();
            this._serializer28 = safeContext.GetSerializer<System.Collections.ObjectModel.Collection<MsgPack.MessagePackObject>>();
            this._serializer29 = safeContext.GetSerializer<System.Collections.ObjectModel.Collection<System.DateTime>>();
            this._serializer30 = safeContext.GetSerializer<System.Collections.ObjectModel.Collection<object>>();
            this._serializer31 = safeContext.GetSerializer<System.Numerics.Complex>();
            this._serializer32 = safeContext.GetSerializer<System.DateTimeOffset>();
            this._serializer33 = safeContext.GetSerializer<decimal>();
            this._serializer34 = safeContext.GetSerializer<System.Collections.Generic.Dictionary<MsgPack.MessagePackObject, MsgPack.MessagePackObject>>();
            this._serializer35 = safeContext.GetSerializer<System.Collections.DictionaryEntry>();
            this._serializer36 = safeContext.GetSerializer<System.Collections.Generic.Dictionary<object, object>>();
            this._serializer37 = safeContext.GetSerializer<System.Collections.Generic.Dictionary<string, System.DateTime>>();
            this._serializer38 = safeContext.GetSerializer<bool>();
            this._serializer39 = safeContext.GetSerializer<System.Runtime.InteropServices.ComTypes.FILETIME>();
            this._serializer40 = safeContext.GetSerializer<System.Guid>();
            this._serializer41 = safeContext.GetSerializer<System.Collections.Generic.HashSet<MsgPack.MessagePackObject>>();
            this._serializer42 = safeContext.GetSerializer<System.Collections.Generic.HashSet<System.DateTime>>();
            this._serializer43 = safeContext.GetSerializer<System.Collections.Generic.HashSet<object>>();
            this._serializer44 = safeContext.GetSerializer<System.Collections.Hashtable>();
            this._serializer45 = safeContext.GetSerializer<System.Collections.Generic.ICollection<MsgPack.MessagePackObject>>();
            this._serializer46 = safeContext.GetSerializer<System.Collections.Generic.ICollection<System.DateTime>>();
            this._serializer47 = safeContext.GetSerializer<System.Collections.Generic.ICollection<object>>();
            this._serializer48 = safeContext.GetSerializer<System.Collections.Generic.IDictionary<MsgPack.MessagePackObject, MsgPack.MessagePackObject>>();
            this._serializer49 = safeContext.GetSerializer<System.Collections.Generic.IDictionary<object, object>>();
            this._serializer50 = safeContext.GetSerializer<System.Collections.Generic.IDictionary<string, System.DateTime>>();
            this._serializer51 = safeContext.GetSerializer<System.Collections.Generic.IList<MsgPack.MessagePackObject>>();
            this._serializer52 = safeContext.GetSerializer<System.Collections.Generic.IList<System.DateTime>>();
            this._serializer53 = safeContext.GetSerializer<System.Collections.Generic.IList<object>>();
            this._serializer54 = safeContext.GetSerializer<MsgPack.Image>();
            this._serializer55 = safeContext.GetSerializer<System.Collections.Generic.ISet<MsgPack.MessagePackObject>>();
            this._serializer56 = safeContext.GetSerializer<System.Collections.Generic.ISet<System.DateTime>>();
            this._serializer57 = safeContext.GetSerializer<System.Collections.Generic.ISet<object>>();
            this._serializer58 = safeContext.GetSerializer<System.Collections.Generic.KeyValuePair<string, System.Numerics.Complex>>();
            this._serializer59 = safeContext.GetSerializer<System.Collections.Generic.KeyValuePair<string, System.DateTimeOffset>>();
            this._serializer60 = safeContext.GetSerializer<System.Collections.Generic.List<MsgPack.MessagePackObject>>();
            this._serializer61 = safeContext.GetSerializer<System.Collections.Generic.List<System.DateTime>>();
            this._serializer62 = safeContext.GetSerializer<System.Collections.Generic.List<object>>();
            this._serializer63 = safeContext.GetSerializer<long>();
            this._serializer64 = safeContext.GetSerializer<ushort>();
            this._serializer65 = safeContext.GetSerializer<System.Collections.ObjectModel.ObservableCollection<MsgPack.MessagePackObject>>();
            this._serializer66 = safeContext.GetSerializer<System.Collections.ObjectModel.ObservableCollection<System.DateTime>>();
            this._serializer67 = safeContext.GetSerializer<System.Collections.ObjectModel.ObservableCollection<object>>();
            this._serializer68 = safeContext.GetSerializer<MsgPack.Serialization.StringKeyedCollection<System.DateTime>>();
            this._serializer69 = safeContext.GetSerializer<MsgPack.Serialization.StringKeyedCollection<MsgPack.MessagePackObject>>();
            this._serializer70 = safeContext.GetSerializer<MsgPack.Serialization.StringKeyedCollection<object>>();
            this._serializer71 = safeContext.GetSerializer<System.TimeSpan>();
            this._serializer72 = safeContext.GetSerializer<System.Tuple<int, string, MsgPack.MessagePackObject, object>>();
            this._serializer73 = safeContext.GetSerializer<System.Version>();
            this._serializer74 = safeContext.GetSerializer<System.Nullable<System.ArraySegment<byte>>>();
            this._serializer75 = safeContext.GetSerializer<System.Nullable<System.ArraySegment<decimal>>>();
            this._serializer76 = safeContext.GetSerializer<System.Nullable<System.ArraySegment<int>>>();
            this._serializer77 = safeContext.GetSerializer<System.Nullable<System.Numerics.BigInteger>>();
            this._serializer78 = safeContext.GetSerializer<System.Nullable<char>>();
            this._serializer79 = safeContext.GetSerializer<System.Nullable<System.Numerics.Complex>>();
            this._serializer80 = safeContext.GetSerializer<System.Nullable<System.DateTimeOffset>>();
            this._serializer81 = safeContext.GetSerializer<System.Nullable<decimal>>();
            this._serializer82 = safeContext.GetSerializer<System.Nullable<System.Collections.DictionaryEntry>>();
            this._serializer83 = safeContext.GetSerializer<System.Nullable<System.Runtime.InteropServices.ComTypes.FILETIME>>();
            this._serializer84 = safeContext.GetSerializer<System.Nullable<System.Guid>>();
            this._serializer85 = safeContext.GetSerializer<System.Nullable<System.Collections.Generic.KeyValuePair<string, System.Numerics.Complex>>>();
            this._serializer86 = safeContext.GetSerializer<System.Nullable<System.Collections.Generic.KeyValuePair<string, System.DateTimeOffset>>>();
            this._serializer87 = safeContext.GetSerializer<System.Nullable<System.TimeSpan>>();
            this._serializer88 = safeContext.GetSerializer<MsgPack.Serialization.ComplexTypeGenerated>();
        }
        
        protected internal override void PackToCore(MsgPack.Packer packer, MsgPack.Serialization.ComplexTypeWithDataContract objectTree) {
            packer.PackMapHeader(4);
            this._serializer13.PackTo(packer, "Data");
            this._serializer15.PackTo(packer, objectTree.Data);
            this._serializer13.PackTo(packer, "History");
            this._serializer16.PackTo(packer, objectTree.History);
            this._serializer13.PackTo(packer, "Source");
            this._serializer14.PackTo(packer, objectTree.Source);
            this._serializer13.PackTo(packer, "TimeStamp");
            this._serializer6.PackTo(packer, objectTree.TimeStamp);
        }
        
        protected internal override MsgPack.Serialization.ComplexTypeWithDataContract UnpackFromCore(MsgPack.Unpacker unpacker) {
            MsgPack.Serialization.ComplexTypeWithDataContract result = default(MsgPack.Serialization.ComplexTypeWithDataContract);
            result = new MsgPack.Serialization.ComplexTypeWithDataContract();
            if (unpacker.IsArrayHeader) {
                int unpacked = default(int);
                int itemsCount = default(int);
                itemsCount = MsgPack.Serialization.UnpackHelpers.GetItemsCount(unpacker);
                byte[] nullable = default(byte[]);
                if ((unpacked < itemsCount)) {
                    nullable = MsgPack.Serialization.UnpackHelpers.UnpackBinaryValue(unpacker, typeof(MsgPack.Serialization.ComplexTypeWithDataContract), "Byte[] Data");
                }
                if (((nullable == null) 
                            == false)) {
                    result.Data = nullable;
                }
                unpacked = (unpacked + 1);
                System.Collections.Generic.Dictionary<System.DateTime, string> nullable0 = default(System.Collections.Generic.Dictionary<System.DateTime, string>);
                if ((unpacked < itemsCount)) {
                    if ((unpacker.Read() == false)) {
                        throw MsgPack.Serialization.SerializationExceptions.NewMissingItem(1);
                    }
                    if (((unpacker.IsArrayHeader == false) 
                                && (unpacker.IsMapHeader == false))) {
                        nullable0 = this._serializer16.UnpackFrom(unpacker);
                    }
                    else {
                        MsgPack.Unpacker disposable = default(MsgPack.Unpacker);
                        disposable = unpacker.ReadSubtree();
                        try {
                            nullable0 = this._serializer16.UnpackFrom(disposable);
                        }
                        finally {
                            if (((disposable == null) 
                                        == false)) {
                                disposable.Dispose();
                            }
                        }
                    }
                }
                if (((nullable0 == null) 
                            == false)) {
                    System.Collections.Generic.Dictionary<System.DateTime, string>.Enumerator enumerator = nullable0.GetEnumerator();
                    System.Collections.Generic.KeyValuePair<System.DateTime, string> current;
                    try {
                        for (
                        ; enumerator.MoveNext(); 
                        ) {
                            current = enumerator.Current;
                            result.History.Add(current.Key, current.Value);
                        }
                    }
                    finally {
                        enumerator.Dispose();
                    }
                }
                unpacked = (unpacked + 1);
                System.Uri nullable1 = default(System.Uri);
                if ((unpacked < itemsCount)) {
                    if ((unpacker.Read() == false)) {
                        throw MsgPack.Serialization.SerializationExceptions.NewMissingItem(2);
                    }
                    if (((unpacker.IsArrayHeader == false) 
                                && (unpacker.IsMapHeader == false))) {
                        nullable1 = this._serializer14.UnpackFrom(unpacker);
                    }
                    else {
                        MsgPack.Unpacker disposable0 = default(MsgPack.Unpacker);
                        disposable0 = unpacker.ReadSubtree();
                        try {
                            nullable1 = this._serializer14.UnpackFrom(disposable0);
                        }
                        finally {
                            if (((disposable0 == null) 
                                        == false)) {
                                disposable0.Dispose();
                            }
                        }
                    }
                }
                if (((nullable1 == null) 
                            == false)) {
                    result.Source = nullable1;
                }
                unpacked = (unpacked + 1);
                System.Nullable<System.DateTime> nullable2 = default(System.Nullable<System.DateTime>);
                if ((unpacked < itemsCount)) {
                    if ((unpacker.Read() == false)) {
                        throw MsgPack.Serialization.SerializationExceptions.NewMissingItem(3);
                    }
                    if (((unpacker.IsArrayHeader == false) 
                                && (unpacker.IsMapHeader == false))) {
                        nullable2 = this._serializer4.UnpackFrom(unpacker);
                    }
                    else {
                        MsgPack.Unpacker disposable1 = default(MsgPack.Unpacker);
                        disposable1 = unpacker.ReadSubtree();
                        try {
                            nullable2 = this._serializer4.UnpackFrom(disposable1);
                        }
                        finally {
                            if (((disposable1 == null) 
                                        == false)) {
                                disposable1.Dispose();
                            }
                        }
                    }
                }
                if (nullable2.HasValue) {
                    result.TimeStamp = nullable2.Value;
                }
                unpacked = (unpacked + 1);
            }
            else {
                int itemsCount0 = default(int);
                itemsCount0 = MsgPack.Serialization.UnpackHelpers.GetItemsCount(unpacker);
                for (int i = 0; (i < itemsCount0); i = (i + 1)) {
                    string key = default(string);
                    string nullable3 = default(string);
                    nullable3 = MsgPack.Serialization.UnpackHelpers.UnpackStringValue(unpacker, typeof(MsgPack.Serialization.ComplexTypeWithDataContract), "MemberName");
                    if (((nullable3 == null) 
                                == false)) {
                        key = nullable3;
                    }
                    else {
                        throw MsgPack.Serialization.SerializationExceptions.NewNullIsProhibited("MemberName");
                    }
                    if ((key == "TimeStamp")) {
                        System.Nullable<System.DateTime> nullable7 = default(System.Nullable<System.DateTime>);
                        if ((unpacker.Read() == false)) {
                            throw MsgPack.Serialization.SerializationExceptions.NewMissingItem(i);
                        }
                        if (((unpacker.IsArrayHeader == false) 
                                    && (unpacker.IsMapHeader == false))) {
                            nullable7 = this._serializer4.UnpackFrom(unpacker);
                        }
                        else {
                            MsgPack.Unpacker disposable4 = default(MsgPack.Unpacker);
                            disposable4 = unpacker.ReadSubtree();
                            try {
                                nullable7 = this._serializer4.UnpackFrom(disposable4);
                            }
                            finally {
                                if (((disposable4 == null) 
                                            == false)) {
                                    disposable4.Dispose();
                                }
                            }
                        }
                        if (nullable7.HasValue) {
                            result.TimeStamp = nullable7.Value;
                        }
                    }
                    else {
                        if ((key == "Source")) {
                            System.Uri nullable6 = default(System.Uri);
                            if ((unpacker.Read() == false)) {
                                throw MsgPack.Serialization.SerializationExceptions.NewMissingItem(i);
                            }
                            if (((unpacker.IsArrayHeader == false) 
                                        && (unpacker.IsMapHeader == false))) {
                                nullable6 = this._serializer14.UnpackFrom(unpacker);
                            }
                            else {
                                MsgPack.Unpacker disposable3 = default(MsgPack.Unpacker);
                                disposable3 = unpacker.ReadSubtree();
                                try {
                                    nullable6 = this._serializer14.UnpackFrom(disposable3);
                                }
                                finally {
                                    if (((disposable3 == null) 
                                                == false)) {
                                        disposable3.Dispose();
                                    }
                                }
                            }
                            if (((nullable6 == null) 
                                        == false)) {
                                result.Source = nullable6;
                            }
                        }
                        else {
                            if ((key == "History")) {
                                System.Collections.Generic.Dictionary<System.DateTime, string> nullable5 = default(System.Collections.Generic.Dictionary<System.DateTime, string>);
                                if ((unpacker.Read() == false)) {
                                    throw MsgPack.Serialization.SerializationExceptions.NewMissingItem(i);
                                }
                                if (((unpacker.IsArrayHeader == false) 
                                            && (unpacker.IsMapHeader == false))) {
                                    nullable5 = this._serializer16.UnpackFrom(unpacker);
                                }
                                else {
                                    MsgPack.Unpacker disposable2 = default(MsgPack.Unpacker);
                                    disposable2 = unpacker.ReadSubtree();
                                    try {
                                        nullable5 = this._serializer16.UnpackFrom(disposable2);
                                    }
                                    finally {
                                        if (((disposable2 == null) 
                                                    == false)) {
                                            disposable2.Dispose();
                                        }
                                    }
                                }
                                if (((nullable5 == null) 
                                            == false)) {
                                    System.Collections.Generic.Dictionary<System.DateTime, string>.Enumerator enumerator0 = nullable5.GetEnumerator();
                                    System.Collections.Generic.KeyValuePair<System.DateTime, string> current0;
                                    try {
                                        for (
                                        ; enumerator0.MoveNext(); 
                                        ) {
                                            current0 = enumerator0.Current;
                                            result.History.Add(current0.Key, current0.Value);
                                        }
                                    }
                                    finally {
                                        enumerator0.Dispose();
                                    }
                                }
                            }
                            else {
                                if ((key == "Data")) {
                                    byte[] nullable4 = default(byte[]);
                                    nullable4 = MsgPack.Serialization.UnpackHelpers.UnpackBinaryValue(unpacker, typeof(MsgPack.Serialization.ComplexTypeWithDataContract), "Byte[] Data");
                                    if (((nullable4 == null) 
                                                == false)) {
                                        result.Data = nullable4;
                                    }
                                }
                            }
                        }
                    }
                }
            }
            return result;
        }
        
        private static T @__Conditional<T>(bool condition, T whenTrue, T whenFalse)
         {
            if (condition) {
                return whenTrue;
            }
            else {
                return whenFalse;
            }
        }
    }
}