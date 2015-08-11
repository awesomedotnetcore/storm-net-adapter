/**
 * Autogenerated by Thrift Compiler (0.9.2)
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


#if !SILVERLIGHT
[Serializable]
#endif
public partial class LSSupervisorId : TBase
{

  public string Supervisor_id { get; set; }

  public LSSupervisorId() {
  }

  public LSSupervisorId(string supervisor_id) : this() {
    this.Supervisor_id = supervisor_id;
  }

  public void Read (TProtocol iprot)
  {
    bool isset_supervisor_id = false;
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
          if (field.Type == TType.String) {
            Supervisor_id = iprot.ReadString();
            isset_supervisor_id = true;
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
    if (!isset_supervisor_id)
      throw new TProtocolException(TProtocolException.INVALID_DATA);
  }

  public void Write(TProtocol oprot) {
    TStruct struc = new TStruct("LSSupervisorId");
    oprot.WriteStructBegin(struc);
    TField field = new TField();
    field.Name = "supervisor_id";
    field.Type = TType.String;
    field.ID = 1;
    oprot.WriteFieldBegin(field);
    oprot.WriteString(Supervisor_id);
    oprot.WriteFieldEnd();
    oprot.WriteFieldStop();
    oprot.WriteStructEnd();
  }

  public override string ToString() {
    StringBuilder __sb = new StringBuilder("LSSupervisorId(");
    __sb.Append(", Supervisor_id: ");
    __sb.Append(Supervisor_id);
    __sb.Append(")");
    return __sb.ToString();
  }

}

