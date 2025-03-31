// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: platform.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Accounts.Api {
  public static partial class AccountsPlatformApi
  {
    static readonly string __ServiceName = "Accounts.AccountsPlatformApi";

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static void __Helper_SerializeMessage(global::Google.Protobuf.IMessage message, grpc::SerializationContext context)
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (message is global::Google.Protobuf.IBufferMessage)
      {
        context.SetPayloadLength(message.CalculateSize());
        global::Google.Protobuf.MessageExtensions.WriteTo(message, context.GetBufferWriter());
        context.Complete();
        return;
      }
      #endif
      context.Complete(global::Google.Protobuf.MessageExtensions.ToByteArray(message));
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static class __Helper_MessageCache<T>
    {
      public static readonly bool IsBufferMessage = global::System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(global::Google.Protobuf.IBufferMessage)).IsAssignableFrom(typeof(T));
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static T __Helper_DeserializeMessage<T>(grpc::DeserializationContext context, global::Google.Protobuf.MessageParser<T> parser) where T : global::Google.Protobuf.IMessage<T>
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (__Helper_MessageCache<T>.IsBufferMessage)
      {
        return parser.ParseFrom(context.PayloadAsReadOnlySequence());
      }
      #endif
      return parser.ParseFrom(context.PayloadAsNewBuffer());
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Accounts.Api.ProvisionAccountRequest> __Marshaller_Accounts_ProvisionAccountRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Accounts.Api.ProvisionAccountRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Protobuf.WellKnownTypes.Empty> __Marshaller_google_protobuf_Empty = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Protobuf.WellKnownTypes.Empty.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Accounts.Api.VerifyUserRequest> __Marshaller_Accounts_VerifyUserRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Accounts.Api.VerifyUserRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Accounts.Api.ListAccountSummariesRequest> __Marshaller_Accounts_ListAccountSummariesRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Accounts.Api.ListAccountSummariesRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Accounts.Api.ListAccountSummariesReply> __Marshaller_Accounts_ListAccountSummariesReply = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Accounts.Api.ListAccountSummariesReply.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Accounts.Api.GetAccountSummaryRequest> __Marshaller_Accounts_GetAccountSummaryRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Accounts.Api.GetAccountSummaryRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Accounts.Api.AccountSummary> __Marshaller_Accounts_AccountSummary = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Accounts.Api.AccountSummary.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Accounts.Api.GetEmailVerificationTokenRequest> __Marshaller_Accounts_GetEmailVerificationTokenRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Accounts.Api.GetEmailVerificationTokenRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Accounts.Api.EmailVerificationToken> __Marshaller_Accounts_EmailVerificationToken = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Accounts.Api.EmailVerificationToken.Parser));

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Accounts.Api.ProvisionAccountRequest, global::Google.Protobuf.WellKnownTypes.Empty> __Method_ProvisionAccount = new grpc::Method<global::Accounts.Api.ProvisionAccountRequest, global::Google.Protobuf.WellKnownTypes.Empty>(
        grpc::MethodType.Unary,
        __ServiceName,
        "ProvisionAccount",
        __Marshaller_Accounts_ProvisionAccountRequest,
        __Marshaller_google_protobuf_Empty);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Accounts.Api.VerifyUserRequest, global::Google.Protobuf.WellKnownTypes.Empty> __Method_VerifyUser = new grpc::Method<global::Accounts.Api.VerifyUserRequest, global::Google.Protobuf.WellKnownTypes.Empty>(
        grpc::MethodType.Unary,
        __ServiceName,
        "VerifyUser",
        __Marshaller_Accounts_VerifyUserRequest,
        __Marshaller_google_protobuf_Empty);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Accounts.Api.ListAccountSummariesRequest, global::Accounts.Api.ListAccountSummariesReply> __Method_ListAccountSummaries = new grpc::Method<global::Accounts.Api.ListAccountSummariesRequest, global::Accounts.Api.ListAccountSummariesReply>(
        grpc::MethodType.Unary,
        __ServiceName,
        "ListAccountSummaries",
        __Marshaller_Accounts_ListAccountSummariesRequest,
        __Marshaller_Accounts_ListAccountSummariesReply);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Accounts.Api.GetAccountSummaryRequest, global::Accounts.Api.AccountSummary> __Method_GetAccountSummary = new grpc::Method<global::Accounts.Api.GetAccountSummaryRequest, global::Accounts.Api.AccountSummary>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetAccountSummary",
        __Marshaller_Accounts_GetAccountSummaryRequest,
        __Marshaller_Accounts_AccountSummary);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Accounts.Api.GetEmailVerificationTokenRequest, global::Accounts.Api.EmailVerificationToken> __Method_GetEmailVerificationToken = new grpc::Method<global::Accounts.Api.GetEmailVerificationTokenRequest, global::Accounts.Api.EmailVerificationToken>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetEmailVerificationToken",
        __Marshaller_Accounts_GetEmailVerificationTokenRequest,
        __Marshaller_Accounts_EmailVerificationToken);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Accounts.Api.PlatformReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of AccountsPlatformApi</summary>
    [grpc::BindServiceMethod(typeof(AccountsPlatformApi), "BindService")]
    public abstract partial class AccountsPlatformApiBase
    {
      /// <summary>
      /// commands
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Google.Protobuf.WellKnownTypes.Empty> ProvisionAccount(global::Accounts.Api.ProvisionAccountRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Google.Protobuf.WellKnownTypes.Empty> VerifyUser(global::Accounts.Api.VerifyUserRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// queries
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Accounts.Api.ListAccountSummariesReply> ListAccountSummaries(global::Accounts.Api.ListAccountSummariesRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Accounts.Api.AccountSummary> GetAccountSummary(global::Accounts.Api.GetAccountSummaryRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Accounts.Api.EmailVerificationToken> GetEmailVerificationToken(global::Accounts.Api.GetEmailVerificationTokenRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for AccountsPlatformApi</summary>
    public partial class AccountsPlatformApiClient : grpc::ClientBase<AccountsPlatformApiClient>
    {
      /// <summary>Creates a new client for AccountsPlatformApi</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public AccountsPlatformApiClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for AccountsPlatformApi that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public AccountsPlatformApiClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected AccountsPlatformApiClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected AccountsPlatformApiClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// commands
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Protobuf.WellKnownTypes.Empty ProvisionAccount(global::Accounts.Api.ProvisionAccountRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ProvisionAccount(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// commands
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Protobuf.WellKnownTypes.Empty ProvisionAccount(global::Accounts.Api.ProvisionAccountRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_ProvisionAccount, null, options, request);
      }
      /// <summary>
      /// commands
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Protobuf.WellKnownTypes.Empty> ProvisionAccountAsync(global::Accounts.Api.ProvisionAccountRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ProvisionAccountAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// commands
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Protobuf.WellKnownTypes.Empty> ProvisionAccountAsync(global::Accounts.Api.ProvisionAccountRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_ProvisionAccount, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Protobuf.WellKnownTypes.Empty VerifyUser(global::Accounts.Api.VerifyUserRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return VerifyUser(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Protobuf.WellKnownTypes.Empty VerifyUser(global::Accounts.Api.VerifyUserRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_VerifyUser, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Protobuf.WellKnownTypes.Empty> VerifyUserAsync(global::Accounts.Api.VerifyUserRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return VerifyUserAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Protobuf.WellKnownTypes.Empty> VerifyUserAsync(global::Accounts.Api.VerifyUserRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_VerifyUser, null, options, request);
      }
      /// <summary>
      /// queries
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Accounts.Api.ListAccountSummariesReply ListAccountSummaries(global::Accounts.Api.ListAccountSummariesRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ListAccountSummaries(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// queries
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Accounts.Api.ListAccountSummariesReply ListAccountSummaries(global::Accounts.Api.ListAccountSummariesRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_ListAccountSummaries, null, options, request);
      }
      /// <summary>
      /// queries
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Accounts.Api.ListAccountSummariesReply> ListAccountSummariesAsync(global::Accounts.Api.ListAccountSummariesRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ListAccountSummariesAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// queries
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Accounts.Api.ListAccountSummariesReply> ListAccountSummariesAsync(global::Accounts.Api.ListAccountSummariesRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_ListAccountSummaries, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Accounts.Api.AccountSummary GetAccountSummary(global::Accounts.Api.GetAccountSummaryRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetAccountSummary(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Accounts.Api.AccountSummary GetAccountSummary(global::Accounts.Api.GetAccountSummaryRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetAccountSummary, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Accounts.Api.AccountSummary> GetAccountSummaryAsync(global::Accounts.Api.GetAccountSummaryRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetAccountSummaryAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Accounts.Api.AccountSummary> GetAccountSummaryAsync(global::Accounts.Api.GetAccountSummaryRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetAccountSummary, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Accounts.Api.EmailVerificationToken GetEmailVerificationToken(global::Accounts.Api.GetEmailVerificationTokenRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetEmailVerificationToken(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Accounts.Api.EmailVerificationToken GetEmailVerificationToken(global::Accounts.Api.GetEmailVerificationTokenRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetEmailVerificationToken, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Accounts.Api.EmailVerificationToken> GetEmailVerificationTokenAsync(global::Accounts.Api.GetEmailVerificationTokenRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetEmailVerificationTokenAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Accounts.Api.EmailVerificationToken> GetEmailVerificationTokenAsync(global::Accounts.Api.GetEmailVerificationTokenRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetEmailVerificationToken, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected override AccountsPlatformApiClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new AccountsPlatformApiClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static grpc::ServerServiceDefinition BindService(AccountsPlatformApiBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_ProvisionAccount, serviceImpl.ProvisionAccount)
          .AddMethod(__Method_VerifyUser, serviceImpl.VerifyUser)
          .AddMethod(__Method_ListAccountSummaries, serviceImpl.ListAccountSummaries)
          .AddMethod(__Method_GetAccountSummary, serviceImpl.GetAccountSummary)
          .AddMethod(__Method_GetEmailVerificationToken, serviceImpl.GetEmailVerificationToken).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static void BindService(grpc::ServiceBinderBase serviceBinder, AccountsPlatformApiBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_ProvisionAccount, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Accounts.Api.ProvisionAccountRequest, global::Google.Protobuf.WellKnownTypes.Empty>(serviceImpl.ProvisionAccount));
      serviceBinder.AddMethod(__Method_VerifyUser, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Accounts.Api.VerifyUserRequest, global::Google.Protobuf.WellKnownTypes.Empty>(serviceImpl.VerifyUser));
      serviceBinder.AddMethod(__Method_ListAccountSummaries, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Accounts.Api.ListAccountSummariesRequest, global::Accounts.Api.ListAccountSummariesReply>(serviceImpl.ListAccountSummaries));
      serviceBinder.AddMethod(__Method_GetAccountSummary, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Accounts.Api.GetAccountSummaryRequest, global::Accounts.Api.AccountSummary>(serviceImpl.GetAccountSummary));
      serviceBinder.AddMethod(__Method_GetEmailVerificationToken, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Accounts.Api.GetEmailVerificationTokenRequest, global::Accounts.Api.EmailVerificationToken>(serviceImpl.GetEmailVerificationToken));
    }

  }
}
#endregion
