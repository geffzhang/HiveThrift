/**
 * Autogenerated by Thrift Compiler (0.9.1)
 *
 * DO NOT EDIT UNLESS YOU ARE SURE THAT YOU KNOW WHAT YOU ARE DOING
 *  @generated
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Thrift;
using Thrift.Collections;
using System.Runtime.Serialization;
using Thrift.Protocol;
using Thrift.Transport;

namespace Hive2
{

  #if !SILVERLIGHT
  [Serializable]
  #endif
  public partial class TStructTypeEntry : TBase
  {

    public Dictionary<string, int> NameToTypePtr { get; set; }

    public TStructTypeEntry() {
    }

    public TStructTypeEntry(Dictionary<string, int> nameToTypePtr) : this() {
      this.NameToTypePtr = nameToTypePtr;
    }

    public void Read (TProtocol iprot)
    {
      bool isset_nameToTypePtr = false;
      TField field;
      iprot.ReadStructBegin();
      while (true)
      {
        field = iprot.ReadFieldBegin();
        if (field.Type == TType.Stop) { 
          break;
        }
        switch (field.ID)
        {
          case 1:
            if (field.Type == TType.Map) {
              {
                NameToTypePtr = new Dictionary<string, int>();
                TMap _map5 = iprot.ReadMapBegin();
                for( int _i6 = 0; _i6 < _map5.Count; ++_i6)
                {
                  string _key7;
                  int _val8;
                  _key7 = iprot.ReadString();
                  _val8 = iprot.ReadI32();
                  NameToTypePtr[_key7] = _val8;
                }
                iprot.ReadMapEnd();
              }
              isset_nameToTypePtr = true;
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          default: 
            TProtocolUtil.Skip(iprot, field.Type);
            break;
        }
        iprot.ReadFieldEnd();
      }
      iprot.ReadStructEnd();
      if (!isset_nameToTypePtr)
        throw new TProtocolException(TProtocolException.INVALID_DATA);
    }

    public void Write(TProtocol oprot) {
      TStruct struc = new TStruct("TStructTypeEntry");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      field.Name = "nameToTypePtr";
      field.Type = TType.Map;
      field.ID = 1;
      oprot.WriteFieldBegin(field);
      {
        oprot.WriteMapBegin(new TMap(TType.String, TType.I32, NameToTypePtr.Count));
        foreach (string _iter9 in NameToTypePtr.Keys)
        {
          oprot.WriteString(_iter9);
          oprot.WriteI32(NameToTypePtr[_iter9]);
        }
        oprot.WriteMapEnd();
      }
      oprot.WriteFieldEnd();
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("TStructTypeEntry(");
      sb.Append("NameToTypePtr: ");
      sb.Append(NameToTypePtr);
      sb.Append(")");
      return sb.ToString();
    }

  }

}
