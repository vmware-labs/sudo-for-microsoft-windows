//Copyright 2023 VMware, Inc.
//SPDX-License-Identifier: BSD-2-Clause
// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: SudoMessaging.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace SudoForWindows_Shared {

  /// <summary>Holder for reflection information generated from SudoMessaging.proto</summary>
  public static partial class SudoMessagingReflection {

    #region Descriptor
    /// <summary>File descriptor for SudoMessaging.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SudoMessagingReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChNTdWRvTWVzc2FnaW5nLnByb3RvEhtTdWRvRm9yV2luZG93c19NZXNzYWdl",
            "VHlwZXMiQgoWU3Vkb0NvbW1hbmRSZXF1ZXN0X3BiMxIVCg1Db21tYW5kU3Ry",
            "aW5nGAEgASgJEhEKCVJ1bkFzVXNlchgCIAEoCSJsChVTdWRvQ29tbWFuZE91",
            "dHB1dF9wYjMSEgoKT3V0cHV0TGluZRgBIAEoCRI/CgpPdXRwdXRUeXBlGAIg",
            "ASgOMisuU3Vkb0ZvcldpbmRvd3NfTWVzc2FnZVR5cGVzLk91dHB1dFR5cGVf",
            "cGIzKj0KDk91dHB1dFR5cGVfcGIzEgoKBlNURE9VVBAAEgoKBlNUREVSUhAB",
            "EgoKBlNZU1RFTRACEgcKA0VPRhAEQhiqAhVTdWRvRm9yV2luZG93c19TaGFy",
            "ZWRiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::SudoForWindows_Shared.OutputType_pb3), }, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::SudoForWindows_Shared.SudoCommandRequest_pb3), global::SudoForWindows_Shared.SudoCommandRequest_pb3.Parser, new[]{ "CommandString", "RunAsUser" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::SudoForWindows_Shared.SudoCommandOutput_pb3), global::SudoForWindows_Shared.SudoCommandOutput_pb3.Parser, new[]{ "OutputLine", "OutputType" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Enums
  public enum OutputType_pb3 {
    [pbr::OriginalName("STDOUT")] Stdout = 0,
    [pbr::OriginalName("STDERR")] Stderr = 1,
    [pbr::OriginalName("SYSTEM")] System = 2,
    [pbr::OriginalName("EOF")] Eof = 4,
  }

  #endregion

  #region Messages
  public sealed partial class SudoCommandRequest_pb3 : pb::IMessage<SudoCommandRequest_pb3>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<SudoCommandRequest_pb3> _parser = new pb::MessageParser<SudoCommandRequest_pb3>(() => new SudoCommandRequest_pb3());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<SudoCommandRequest_pb3> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::SudoForWindows_Shared.SudoMessagingReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SudoCommandRequest_pb3() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SudoCommandRequest_pb3(SudoCommandRequest_pb3 other) : this() {
      commandString_ = other.commandString_;
      runAsUser_ = other.runAsUser_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SudoCommandRequest_pb3 Clone() {
      return new SudoCommandRequest_pb3(this);
    }

    /// <summary>Field number for the "CommandString" field.</summary>
    public const int CommandStringFieldNumber = 1;
    private string commandString_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string CommandString {
      get { return commandString_; }
      set {
        commandString_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "RunAsUser" field.</summary>
    public const int RunAsUserFieldNumber = 2;
    private string runAsUser_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string RunAsUser {
      get { return runAsUser_; }
      set {
        runAsUser_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as SudoCommandRequest_pb3);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(SudoCommandRequest_pb3 other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (CommandString != other.CommandString) return false;
      if (RunAsUser != other.RunAsUser) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (CommandString.Length != 0) hash ^= CommandString.GetHashCode();
      if (RunAsUser.Length != 0) hash ^= RunAsUser.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (CommandString.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(CommandString);
      }
      if (RunAsUser.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(RunAsUser);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (CommandString.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(CommandString);
      }
      if (RunAsUser.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(RunAsUser);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (CommandString.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(CommandString);
      }
      if (RunAsUser.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(RunAsUser);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(SudoCommandRequest_pb3 other) {
      if (other == null) {
        return;
      }
      if (other.CommandString.Length != 0) {
        CommandString = other.CommandString;
      }
      if (other.RunAsUser.Length != 0) {
        RunAsUser = other.RunAsUser;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            CommandString = input.ReadString();
            break;
          }
          case 18: {
            RunAsUser = input.ReadString();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            CommandString = input.ReadString();
            break;
          }
          case 18: {
            RunAsUser = input.ReadString();
            break;
          }
        }
      }
    }
    #endif

  }

  public sealed partial class SudoCommandOutput_pb3 : pb::IMessage<SudoCommandOutput_pb3>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<SudoCommandOutput_pb3> _parser = new pb::MessageParser<SudoCommandOutput_pb3>(() => new SudoCommandOutput_pb3());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<SudoCommandOutput_pb3> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::SudoForWindows_Shared.SudoMessagingReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SudoCommandOutput_pb3() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SudoCommandOutput_pb3(SudoCommandOutput_pb3 other) : this() {
      outputLine_ = other.outputLine_;
      outputType_ = other.outputType_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SudoCommandOutput_pb3 Clone() {
      return new SudoCommandOutput_pb3(this);
    }

    /// <summary>Field number for the "OutputLine" field.</summary>
    public const int OutputLineFieldNumber = 1;
    private string outputLine_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string OutputLine {
      get { return outputLine_; }
      set {
        outputLine_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "OutputType" field.</summary>
    public const int OutputTypeFieldNumber = 2;
    private global::SudoForWindows_Shared.OutputType_pb3 outputType_ = global::SudoForWindows_Shared.OutputType_pb3.Stdout;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::SudoForWindows_Shared.OutputType_pb3 OutputType {
      get { return outputType_; }
      set {
        outputType_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as SudoCommandOutput_pb3);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(SudoCommandOutput_pb3 other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (OutputLine != other.OutputLine) return false;
      if (OutputType != other.OutputType) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (OutputLine.Length != 0) hash ^= OutputLine.GetHashCode();
      if (OutputType != global::SudoForWindows_Shared.OutputType_pb3.Stdout) hash ^= OutputType.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (OutputLine.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(OutputLine);
      }
      if (OutputType != global::SudoForWindows_Shared.OutputType_pb3.Stdout) {
        output.WriteRawTag(16);
        output.WriteEnum((int) OutputType);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (OutputLine.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(OutputLine);
      }
      if (OutputType != global::SudoForWindows_Shared.OutputType_pb3.Stdout) {
        output.WriteRawTag(16);
        output.WriteEnum((int) OutputType);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (OutputLine.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(OutputLine);
      }
      if (OutputType != global::SudoForWindows_Shared.OutputType_pb3.Stdout) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) OutputType);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(SudoCommandOutput_pb3 other) {
      if (other == null) {
        return;
      }
      if (other.OutputLine.Length != 0) {
        OutputLine = other.OutputLine;
      }
      if (other.OutputType != global::SudoForWindows_Shared.OutputType_pb3.Stdout) {
        OutputType = other.OutputType;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            OutputLine = input.ReadString();
            break;
          }
          case 16: {
            OutputType = (global::SudoForWindows_Shared.OutputType_pb3) input.ReadEnum();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            OutputLine = input.ReadString();
            break;
          }
          case 16: {
            OutputType = (global::SudoForWindows_Shared.OutputType_pb3) input.ReadEnum();
            break;
          }
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code
