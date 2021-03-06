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
  public partial class TCancelDelegationTokenReq : TBase
  {

    public TSessionHandle SessionHandle { get; set; }

    public string DelegationToken { get; set; }

    public TCancelDelegationTokenReq() {
    }

    public TCancelDelegationTokenReq(TSessionHandle sessionHandle, string delegationToken) : this() {
      this.SessionHandle = sessionHandle;
      this.DelegationToken = delegationToken;
    }

    public void Read (TProtocol iprot)
    {
      bool isset_sessionHandle = false;
      bool isset_delegationToken = false;
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
            if (field.Type == TType.Struct) {
              SessionHandle = new TSessionHandle();
              SessionHandle.Read(iprot);
              isset_sessionHandle = true;
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 2:
            if (field.Type == TType.String) {
              DelegationToken = iprot.ReadString();
              isset_delegationToken = true;
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
      if (!isset_sessionHandle)
        throw new TProtocolException(TProtocolException.INVALID_DATA);
      if (!isset_delegationToken)
        throw new TProtocolException(TProtocolException.INVALID_DATA);
    }

    public void Write(TProtocol oprot) {
      TStruct struc = new TStruct("TCancelDelegationTokenReq");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      field.Name = "sessionHandle";
      field.Type = TType.Struct;
      field.ID = 1;
      oprot.WriteFieldBegin(field);
      SessionHandle.Write(oprot);
      oprot.WriteFieldEnd();
      field.Name = "delegationToken";
      field.Type = TType.String;
      field.ID = 2;
      oprot.WriteFieldBegin(field);
      oprot.WriteString(DelegationToken);
      oprot.WriteFieldEnd();
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("TCancelDelegationTokenReq(");
      sb.Append("SessionHandle: ");
      sb.Append(SessionHandle== null ? "<null>" : SessionHandle.ToString());
      sb.Append(",DelegationToken: ");
      sb.Append(DelegationToken);
      sb.Append(")");
      return sb.ToString();
    }

  }

}
