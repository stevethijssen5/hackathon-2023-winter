//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Substrate.NetApi.Attributes;
using Substrate.NetApi.Model.Types.Base;
using Substrate.NetApi.Model.Types.Metadata.V14;
using System.Collections.Generic;


namespace Substrate.Hexalem.NET.NetApiExt.Generated.Model.hexalem_runtime
{
    
    
    /// <summary>
    /// >> 130 - Composite[hexalem_runtime.HexalemTile]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class HexalemTile : BaseType
    {
        
        /// <summary>
        /// >> tile_type
        /// </summary>
        private Substrate.Hexalem.NET.NetApiExt.Generated.Model.pallet_hexalem.pallet.EnumTileType _tileType;
        
        /// <summary>
        /// >> tile_level
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.U8 _tileLevel;
        
        /// <summary>
        /// >> formations
        /// </summary>
        private Substrate.Hexalem.NET.NetApiExt.Generated.Types.Base.Arr3Bool _formations;
        
        public Substrate.Hexalem.NET.NetApiExt.Generated.Model.pallet_hexalem.pallet.EnumTileType TileType
        {
            get
            {
                return this._tileType;
            }
            set
            {
                this._tileType = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Primitive.U8 TileLevel
        {
            get
            {
                return this._tileLevel;
            }
            set
            {
                this._tileLevel = value;
            }
        }
        
        public Substrate.Hexalem.NET.NetApiExt.Generated.Types.Base.Arr3Bool Formations
        {
            get
            {
                return this._formations;
            }
            set
            {
                this._formations = value;
            }
        }
        
        public override string TypeName()
        {
            return "HexalemTile";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(TileType.Encode());
            result.AddRange(TileLevel.Encode());
            result.AddRange(Formations.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            TileType = new Substrate.Hexalem.NET.NetApiExt.Generated.Model.pallet_hexalem.pallet.EnumTileType();
            TileType.Decode(byteArray, ref p);
            TileLevel = new Substrate.NetApi.Model.Types.Primitive.U8();
            TileLevel.Decode(byteArray, ref p);
            Formations = new Substrate.Hexalem.NET.NetApiExt.Generated.Types.Base.Arr3Bool();
            Formations.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}
