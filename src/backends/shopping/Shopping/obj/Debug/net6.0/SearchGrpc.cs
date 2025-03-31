// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: search.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Search.Api {
  public static partial class SearchApi
  {
    static readonly string __ServiceName = "search.SearchApi";

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
    static readonly grpc::Marshaller<global::Search.Api.SearchRequest> __Marshaller_search_SearchRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Search.Api.SearchRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Search.Api.SearchResponse> __Marshaller_search_SearchResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Search.Api.SearchResponse.Parser));

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Search.Api.SearchRequest, global::Search.Api.SearchResponse> __Method_Search = new grpc::Method<global::Search.Api.SearchRequest, global::Search.Api.SearchResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Search",
        __Marshaller_search_SearchRequest,
        __Marshaller_search_SearchResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Search.Api.SearchReflection.Descriptor.Services[0]; }
    }

    /// <summary>Client for SearchApi</summary>
    public partial class SearchApiClient : grpc::ClientBase<SearchApiClient>
    {
      /// <summary>Creates a new client for SearchApi</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public SearchApiClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for SearchApi that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public SearchApiClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected SearchApiClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected SearchApiClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Search.Api.SearchResponse Search(global::Search.Api.SearchRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return Search(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Search.Api.SearchResponse Search(global::Search.Api.SearchRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Search, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Search.Api.SearchResponse> SearchAsync(global::Search.Api.SearchRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return SearchAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Search.Api.SearchResponse> SearchAsync(global::Search.Api.SearchRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Search, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected override SearchApiClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new SearchApiClient(configuration);
      }
    }

  }
}
#endregion
