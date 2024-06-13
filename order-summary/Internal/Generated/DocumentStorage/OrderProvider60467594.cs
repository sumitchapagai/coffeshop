// <auto-generated/>
#pragma warning disable
using CoffeeShop.OrderSummary.Models;
using Marten.Internal;
using Marten.Internal.Storage;
using Marten.Schema;
using Marten.Schema.Arguments;
using Npgsql;
using System;
using System.Collections.Generic;
using Weasel.Core;
using Weasel.Postgresql;

namespace Marten.Generated.DocumentStorage
{
    // START: UpsertOrderOperation60467594
    public class UpsertOrderOperation60467594 : Marten.Internal.Operations.StorageOperation<CoffeeShop.OrderSummary.Models.Order, System.Guid>
    {
        private readonly CoffeeShop.OrderSummary.Models.Order _document;
        private readonly System.Guid _id;
        private readonly System.Collections.Generic.Dictionary<System.Guid, System.Guid> _versions;
        private readonly Marten.Schema.DocumentMapping _mapping;

        public UpsertOrderOperation60467594(CoffeeShop.OrderSummary.Models.Order document, System.Guid id, System.Collections.Generic.Dictionary<System.Guid, System.Guid> versions, Marten.Schema.DocumentMapping mapping) : base(document, id, versions, mapping)
        {
            _document = document;
            _id = id;
            _versions = versions;
            _mapping = mapping;
        }


        public const string COMMAND_TEXT = "select order_summary.mt_upsert_order(?, ?, ?, ?)";


        public override void Postprocess(System.Data.Common.DbDataReader reader, System.Collections.Generic.IList<System.Exception> exceptions)
        {
            if (postprocessRevision(reader, exceptions))
            {
            }

        }


        public override async System.Threading.Tasks.Task PostprocessAsync(System.Data.Common.DbDataReader reader, System.Collections.Generic.IList<System.Exception> exceptions, System.Threading.CancellationToken token)
        {
            if (await postprocessRevisionAsync(reader, exceptions, token))
            {
            }

        }


        public override Marten.Internal.Operations.OperationRole Role()
        {
            return Marten.Internal.Operations.OperationRole.Upsert;
        }


        public override string CommandText()
        {
            return COMMAND_TEXT;
        }


        public override NpgsqlTypes.NpgsqlDbType DbType()
        {
            return NpgsqlTypes.NpgsqlDbType.Uuid;
        }


        public override void ConfigureParameters(Npgsql.NpgsqlParameter[] parameters, CoffeeShop.OrderSummary.Models.Order document, Marten.Internal.IMartenSession session)
        {
            parameters[0].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Jsonb;
            parameters[0].Value = session.Serializer.ToJson(_document);
            // .Net Class Type
            parameters[1].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Varchar;
            parameters[1].Value = _document.GetType().FullName;
            parameters[2].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Uuid;
            parameters[2].Value = document.Id;
            setCurrentRevisionParameter(parameters[3]);
        }

    }

    // END: UpsertOrderOperation60467594
    
    
    // START: InsertOrderOperation60467594
    public class InsertOrderOperation60467594 : Marten.Internal.Operations.StorageOperation<CoffeeShop.OrderSummary.Models.Order, System.Guid>
    {
        private readonly CoffeeShop.OrderSummary.Models.Order _document;
        private readonly System.Guid _id;
        private readonly System.Collections.Generic.Dictionary<System.Guid, System.Guid> _versions;
        private readonly Marten.Schema.DocumentMapping _mapping;

        public InsertOrderOperation60467594(CoffeeShop.OrderSummary.Models.Order document, System.Guid id, System.Collections.Generic.Dictionary<System.Guid, System.Guid> versions, Marten.Schema.DocumentMapping mapping) : base(document, id, versions, mapping)
        {
            _document = document;
            _id = id;
            _versions = versions;
            _mapping = mapping;
        }


        public const string COMMAND_TEXT = "select order_summary.mt_insert_order(?, ?, ?, ?)";


        public override void Postprocess(System.Data.Common.DbDataReader reader, System.Collections.Generic.IList<System.Exception> exceptions)
        {
            if (postprocessRevision(reader, exceptions))
            {
            }

        }


        public override async System.Threading.Tasks.Task PostprocessAsync(System.Data.Common.DbDataReader reader, System.Collections.Generic.IList<System.Exception> exceptions, System.Threading.CancellationToken token)
        {
            if (await postprocessRevisionAsync(reader, exceptions, token))
            {
            }

        }


        public override Marten.Internal.Operations.OperationRole Role()
        {
            return Marten.Internal.Operations.OperationRole.Insert;
        }


        public override string CommandText()
        {
            return COMMAND_TEXT;
        }


        public override NpgsqlTypes.NpgsqlDbType DbType()
        {
            return NpgsqlTypes.NpgsqlDbType.Uuid;
        }


        public override void ConfigureParameters(Npgsql.NpgsqlParameter[] parameters, CoffeeShop.OrderSummary.Models.Order document, Marten.Internal.IMartenSession session)
        {
            parameters[0].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Jsonb;
            parameters[0].Value = session.Serializer.ToJson(_document);
            // .Net Class Type
            parameters[1].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Varchar;
            parameters[1].Value = _document.GetType().FullName;
            parameters[2].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Uuid;
            parameters[2].Value = document.Id;
            setCurrentRevisionParameter(parameters[3]);
        }

    }

    // END: InsertOrderOperation60467594
    
    
    // START: UpdateOrderOperation60467594
    public class UpdateOrderOperation60467594 : Marten.Internal.Operations.StorageOperation<CoffeeShop.OrderSummary.Models.Order, System.Guid>
    {
        private readonly CoffeeShop.OrderSummary.Models.Order _document;
        private readonly System.Guid _id;
        private readonly System.Collections.Generic.Dictionary<System.Guid, System.Guid> _versions;
        private readonly Marten.Schema.DocumentMapping _mapping;

        public UpdateOrderOperation60467594(CoffeeShop.OrderSummary.Models.Order document, System.Guid id, System.Collections.Generic.Dictionary<System.Guid, System.Guid> versions, Marten.Schema.DocumentMapping mapping) : base(document, id, versions, mapping)
        {
            _document = document;
            _id = id;
            _versions = versions;
            _mapping = mapping;
        }


        public const string COMMAND_TEXT = "select order_summary.mt_update_order(?, ?, ?, ?)";


        public override void Postprocess(System.Data.Common.DbDataReader reader, System.Collections.Generic.IList<System.Exception> exceptions)
        {
            if (postprocessRevision(reader, exceptions))
            {
            }

        }


        public override async System.Threading.Tasks.Task PostprocessAsync(System.Data.Common.DbDataReader reader, System.Collections.Generic.IList<System.Exception> exceptions, System.Threading.CancellationToken token)
        {
            if (await postprocessRevisionAsync(reader, exceptions, token))
            {
            }

        }


        public override Marten.Internal.Operations.OperationRole Role()
        {
            return Marten.Internal.Operations.OperationRole.Update;
        }


        public override string CommandText()
        {
            return COMMAND_TEXT;
        }


        public override NpgsqlTypes.NpgsqlDbType DbType()
        {
            return NpgsqlTypes.NpgsqlDbType.Uuid;
        }


        public override void ConfigureParameters(Npgsql.NpgsqlParameter[] parameters, CoffeeShop.OrderSummary.Models.Order document, Marten.Internal.IMartenSession session)
        {
            parameters[0].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Jsonb;
            parameters[0].Value = session.Serializer.ToJson(_document);
            // .Net Class Type
            parameters[1].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Varchar;
            parameters[1].Value = _document.GetType().FullName;
            parameters[2].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Uuid;
            parameters[2].Value = document.Id;
            setCurrentRevisionParameter(parameters[3]);
        }

    }

    // END: UpdateOrderOperation60467594
    
    
    // START: QueryOnlyOrderSelector60467594
    public class QueryOnlyOrderSelector60467594 : Marten.Internal.CodeGeneration.DocumentSelectorWithOnlySerializer, Marten.Linq.Selectors.ISelector<CoffeeShop.OrderSummary.Models.Order>
    {
        private readonly Marten.Internal.IMartenSession _session;
        private readonly Marten.Schema.DocumentMapping _mapping;

        public QueryOnlyOrderSelector60467594(Marten.Internal.IMartenSession session, Marten.Schema.DocumentMapping mapping) : base(session, mapping)
        {
            _session = session;
            _mapping = mapping;
        }



        public CoffeeShop.OrderSummary.Models.Order Resolve(System.Data.Common.DbDataReader reader)
        {

            CoffeeShop.OrderSummary.Models.Order document;
            document = _serializer.FromJson<CoffeeShop.OrderSummary.Models.Order>(reader, 0);
            return document;
        }


        public async System.Threading.Tasks.Task<CoffeeShop.OrderSummary.Models.Order> ResolveAsync(System.Data.Common.DbDataReader reader, System.Threading.CancellationToken token)
        {

            CoffeeShop.OrderSummary.Models.Order document;
            document = await _serializer.FromJsonAsync<CoffeeShop.OrderSummary.Models.Order>(reader, 0, token).ConfigureAwait(false);
            return document;
        }

    }

    // END: QueryOnlyOrderSelector60467594
    
    
    // START: LightweightOrderSelector60467594
    public class LightweightOrderSelector60467594 : Marten.Internal.CodeGeneration.DocumentSelectorWithOnlySerializer, Marten.Linq.Selectors.ISelector<CoffeeShop.OrderSummary.Models.Order>
    {
        private readonly Marten.Internal.IMartenSession _session;
        private readonly Marten.Schema.DocumentMapping _mapping;

        public LightweightOrderSelector60467594(Marten.Internal.IMartenSession session, Marten.Schema.DocumentMapping mapping) : base(session, mapping)
        {
            _session = session;
            _mapping = mapping;
        }



        public CoffeeShop.OrderSummary.Models.Order Resolve(System.Data.Common.DbDataReader reader)
        {
            var id = reader.GetFieldValue<System.Guid>(0);

            CoffeeShop.OrderSummary.Models.Order document;
            document = _serializer.FromJson<CoffeeShop.OrderSummary.Models.Order>(reader, 1);
            var version = reader.GetFieldValue<int>(2);
            _session.MarkAsDocumentLoaded(id, document);
            return document;
        }


        public async System.Threading.Tasks.Task<CoffeeShop.OrderSummary.Models.Order> ResolveAsync(System.Data.Common.DbDataReader reader, System.Threading.CancellationToken token)
        {
            var id = await reader.GetFieldValueAsync<System.Guid>(0, token);

            CoffeeShop.OrderSummary.Models.Order document;
            document = await _serializer.FromJsonAsync<CoffeeShop.OrderSummary.Models.Order>(reader, 1, token).ConfigureAwait(false);
            var version = await reader.GetFieldValueAsync<int>(2, token);
            _session.MarkAsDocumentLoaded(id, document);
            return document;
        }

    }

    // END: LightweightOrderSelector60467594
    
    
    // START: IdentityMapOrderSelector60467594
    public class IdentityMapOrderSelector60467594 : Marten.Internal.CodeGeneration.DocumentSelectorWithIdentityMap<CoffeeShop.OrderSummary.Models.Order, System.Guid>, Marten.Linq.Selectors.ISelector<CoffeeShop.OrderSummary.Models.Order>
    {
        private readonly Marten.Internal.IMartenSession _session;
        private readonly Marten.Schema.DocumentMapping _mapping;

        public IdentityMapOrderSelector60467594(Marten.Internal.IMartenSession session, Marten.Schema.DocumentMapping mapping) : base(session, mapping)
        {
            _session = session;
            _mapping = mapping;
        }



        public CoffeeShop.OrderSummary.Models.Order Resolve(System.Data.Common.DbDataReader reader)
        {
            var id = reader.GetFieldValue<System.Guid>(0);
            if (_identityMap.TryGetValue(id, out var existing)) return existing;

            CoffeeShop.OrderSummary.Models.Order document;
            document = _serializer.FromJson<CoffeeShop.OrderSummary.Models.Order>(reader, 1);
            var version = reader.GetFieldValue<int>(2);
            _session.MarkAsDocumentLoaded(id, document);
            _identityMap[id] = document;
            return document;
        }


        public async System.Threading.Tasks.Task<CoffeeShop.OrderSummary.Models.Order> ResolveAsync(System.Data.Common.DbDataReader reader, System.Threading.CancellationToken token)
        {
            var id = await reader.GetFieldValueAsync<System.Guid>(0, token);
            if (_identityMap.TryGetValue(id, out var existing)) return existing;

            CoffeeShop.OrderSummary.Models.Order document;
            document = await _serializer.FromJsonAsync<CoffeeShop.OrderSummary.Models.Order>(reader, 1, token).ConfigureAwait(false);
            var version = await reader.GetFieldValueAsync<int>(2, token);
            _session.MarkAsDocumentLoaded(id, document);
            _identityMap[id] = document;
            return document;
        }

    }

    // END: IdentityMapOrderSelector60467594
    
    
    // START: DirtyTrackingOrderSelector60467594
    public class DirtyTrackingOrderSelector60467594 : Marten.Internal.CodeGeneration.DocumentSelectorWithDirtyChecking<CoffeeShop.OrderSummary.Models.Order, System.Guid>, Marten.Linq.Selectors.ISelector<CoffeeShop.OrderSummary.Models.Order>
    {
        private readonly Marten.Internal.IMartenSession _session;
        private readonly Marten.Schema.DocumentMapping _mapping;

        public DirtyTrackingOrderSelector60467594(Marten.Internal.IMartenSession session, Marten.Schema.DocumentMapping mapping) : base(session, mapping)
        {
            _session = session;
            _mapping = mapping;
        }



        public CoffeeShop.OrderSummary.Models.Order Resolve(System.Data.Common.DbDataReader reader)
        {
            var id = reader.GetFieldValue<System.Guid>(0);
            if (_identityMap.TryGetValue(id, out var existing)) return existing;

            CoffeeShop.OrderSummary.Models.Order document;
            document = _serializer.FromJson<CoffeeShop.OrderSummary.Models.Order>(reader, 1);
            var version = reader.GetFieldValue<int>(2);
            _session.MarkAsDocumentLoaded(id, document);
            _identityMap[id] = document;
            StoreTracker(_session, document);
            return document;
        }


        public async System.Threading.Tasks.Task<CoffeeShop.OrderSummary.Models.Order> ResolveAsync(System.Data.Common.DbDataReader reader, System.Threading.CancellationToken token)
        {
            var id = await reader.GetFieldValueAsync<System.Guid>(0, token);
            if (_identityMap.TryGetValue(id, out var existing)) return existing;

            CoffeeShop.OrderSummary.Models.Order document;
            document = await _serializer.FromJsonAsync<CoffeeShop.OrderSummary.Models.Order>(reader, 1, token).ConfigureAwait(false);
            var version = await reader.GetFieldValueAsync<int>(2, token);
            _session.MarkAsDocumentLoaded(id, document);
            _identityMap[id] = document;
            StoreTracker(_session, document);
            return document;
        }

    }

    // END: DirtyTrackingOrderSelector60467594
    
    
    // START: OverwriteOrderOperation60467594
    public class OverwriteOrderOperation60467594 : Marten.Internal.Operations.StorageOperation<CoffeeShop.OrderSummary.Models.Order, System.Guid>
    {
        private readonly CoffeeShop.OrderSummary.Models.Order _document;
        private readonly System.Guid _id;
        private readonly System.Collections.Generic.Dictionary<System.Guid, System.Guid> _versions;
        private readonly Marten.Schema.DocumentMapping _mapping;

        public OverwriteOrderOperation60467594(CoffeeShop.OrderSummary.Models.Order document, System.Guid id, System.Collections.Generic.Dictionary<System.Guid, System.Guid> versions, Marten.Schema.DocumentMapping mapping) : base(document, id, versions, mapping)
        {
            _document = document;
            _id = id;
            _versions = versions;
            _mapping = mapping;
        }


        public const string COMMAND_TEXT = "select order_summary.mt_overwrite_order(?, ?, ?, ?)";


        public override void Postprocess(System.Data.Common.DbDataReader reader, System.Collections.Generic.IList<System.Exception> exceptions)
        {
            if (postprocessRevision(reader, exceptions))
            {
            }

        }


        public override async System.Threading.Tasks.Task PostprocessAsync(System.Data.Common.DbDataReader reader, System.Collections.Generic.IList<System.Exception> exceptions, System.Threading.CancellationToken token)
        {
            if (await postprocessRevisionAsync(reader, exceptions, token))
            {
            }

        }


        public override Marten.Internal.Operations.OperationRole Role()
        {
            return Marten.Internal.Operations.OperationRole.Update;
        }


        public override string CommandText()
        {
            return COMMAND_TEXT;
        }


        public override NpgsqlTypes.NpgsqlDbType DbType()
        {
            return NpgsqlTypes.NpgsqlDbType.Uuid;
        }


        public override void ConfigureParameters(Npgsql.NpgsqlParameter[] parameters, CoffeeShop.OrderSummary.Models.Order document, Marten.Internal.IMartenSession session)
        {
            parameters[0].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Jsonb;
            parameters[0].Value = session.Serializer.ToJson(_document);
            // .Net Class Type
            parameters[1].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Varchar;
            parameters[1].Value = _document.GetType().FullName;
            parameters[2].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Uuid;
            parameters[2].Value = document.Id;
            setCurrentRevisionParameter(parameters[3]);
        }

    }

    // END: OverwriteOrderOperation60467594
    
    
    // START: QueryOnlyOrderDocumentStorage60467594
    public class QueryOnlyOrderDocumentStorage60467594 : Marten.Internal.Storage.QueryOnlyDocumentStorage<CoffeeShop.OrderSummary.Models.Order, System.Guid>
    {
        private readonly Marten.Schema.DocumentMapping _document;

        public QueryOnlyOrderDocumentStorage60467594(Marten.Schema.DocumentMapping document) : base(document)
        {
            _document = document;
        }



        public override System.Guid AssignIdentity(CoffeeShop.OrderSummary.Models.Order document, string tenantId, Marten.Storage.IMartenDatabase database)
        {
            if (document.Id == Guid.Empty) _setter(document, Marten.Schema.Identity.CombGuidIdGeneration.NewGuid());
            return document.Id;
        }


        public override Marten.Internal.Operations.IStorageOperation Update(CoffeeShop.OrderSummary.Models.Order document, Marten.Internal.IMartenSession session, string tenant)
        {
            if (session.Concurrency == Marten.Services.ConcurrencyChecks.Disabled)
            {

                return new Marten.Generated.DocumentStorage.OverwriteOrderOperation60467594
                (
                    document, Identity(document),
                    null,
                    _document
                    
                );
            }

            else
            {

                return new Marten.Generated.DocumentStorage.UpdateOrderOperation60467594
                (
                    document, Identity(document),
                    null,
                    _document
                    
                );
            }

        }


        public override Marten.Internal.Operations.IStorageOperation Insert(CoffeeShop.OrderSummary.Models.Order document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.InsertOrderOperation60467594
            (
                document, Identity(document),
                null,
                _document
                
            );
        }


        public override Marten.Internal.Operations.IStorageOperation Upsert(CoffeeShop.OrderSummary.Models.Order document, Marten.Internal.IMartenSession session, string tenant)
        {
            if (session.Concurrency == Marten.Services.ConcurrencyChecks.Disabled)
            {

                return new Marten.Generated.DocumentStorage.OverwriteOrderOperation60467594
                (
                    document, Identity(document),
                    null,
                    _document
                    
                );
            }

            else
            {

                return new Marten.Generated.DocumentStorage.UpsertOrderOperation60467594
                (
                    document, Identity(document),
                    null,
                    _document
                    
                );
            }

        }


        public override Marten.Internal.Operations.IStorageOperation Overwrite(CoffeeShop.OrderSummary.Models.Order document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.OverwriteOrderOperation60467594
            (
                document, Identity(document),
                null,
                _document
                
            );

            return new Marten.Generated.DocumentStorage.OverwriteOrderOperation60467594
            (
                document, Identity(document),
                null,
                _document
                
            );
        }


        public override System.Guid Identity(CoffeeShop.OrderSummary.Models.Order document)
        {
            return document.Id;
        }


        public override Marten.Linq.Selectors.ISelector BuildSelector(Marten.Internal.IMartenSession session)
        {
            return new Marten.Generated.DocumentStorage.QueryOnlyOrderSelector60467594(session, _document);
        }

    }

    // END: QueryOnlyOrderDocumentStorage60467594
    
    
    // START: LightweightOrderDocumentStorage60467594
    public class LightweightOrderDocumentStorage60467594 : Marten.Internal.Storage.LightweightDocumentStorage<CoffeeShop.OrderSummary.Models.Order, System.Guid>
    {
        private readonly Marten.Schema.DocumentMapping _document;

        public LightweightOrderDocumentStorage60467594(Marten.Schema.DocumentMapping document) : base(document)
        {
            _document = document;
        }



        public override System.Guid AssignIdentity(CoffeeShop.OrderSummary.Models.Order document, string tenantId, Marten.Storage.IMartenDatabase database)
        {
            if (document.Id == Guid.Empty) _setter(document, Marten.Schema.Identity.CombGuidIdGeneration.NewGuid());
            return document.Id;
        }


        public override Marten.Internal.Operations.IStorageOperation Update(CoffeeShop.OrderSummary.Models.Order document, Marten.Internal.IMartenSession session, string tenant)
        {
            if (session.Concurrency == Marten.Services.ConcurrencyChecks.Disabled)
            {

                return new Marten.Generated.DocumentStorage.OverwriteOrderOperation60467594
                (
                    document, Identity(document),
                    null,
                    _document
                    
                );
            }

            else
            {

                return new Marten.Generated.DocumentStorage.UpdateOrderOperation60467594
                (
                    document, Identity(document),
                    null,
                    _document
                    
                );
            }

        }


        public override Marten.Internal.Operations.IStorageOperation Insert(CoffeeShop.OrderSummary.Models.Order document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.InsertOrderOperation60467594
            (
                document, Identity(document),
                null,
                _document
                
            );
        }


        public override Marten.Internal.Operations.IStorageOperation Upsert(CoffeeShop.OrderSummary.Models.Order document, Marten.Internal.IMartenSession session, string tenant)
        {
            if (session.Concurrency == Marten.Services.ConcurrencyChecks.Disabled)
            {

                return new Marten.Generated.DocumentStorage.OverwriteOrderOperation60467594
                (
                    document, Identity(document),
                    null,
                    _document
                    
                );
            }

            else
            {

                return new Marten.Generated.DocumentStorage.UpsertOrderOperation60467594
                (
                    document, Identity(document),
                    null,
                    _document
                    
                );
            }

        }


        public override Marten.Internal.Operations.IStorageOperation Overwrite(CoffeeShop.OrderSummary.Models.Order document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.OverwriteOrderOperation60467594
            (
                document, Identity(document),
                null,
                _document
                
            );

            return new Marten.Generated.DocumentStorage.OverwriteOrderOperation60467594
            (
                document, Identity(document),
                null,
                _document
                
            );
        }


        public override System.Guid Identity(CoffeeShop.OrderSummary.Models.Order document)
        {
            return document.Id;
        }


        public override Marten.Linq.Selectors.ISelector BuildSelector(Marten.Internal.IMartenSession session)
        {
            return new Marten.Generated.DocumentStorage.LightweightOrderSelector60467594(session, _document);
        }

    }

    // END: LightweightOrderDocumentStorage60467594
    
    
    // START: IdentityMapOrderDocumentStorage60467594
    public class IdentityMapOrderDocumentStorage60467594 : Marten.Internal.Storage.IdentityMapDocumentStorage<CoffeeShop.OrderSummary.Models.Order, System.Guid>
    {
        private readonly Marten.Schema.DocumentMapping _document;

        public IdentityMapOrderDocumentStorage60467594(Marten.Schema.DocumentMapping document) : base(document)
        {
            _document = document;
        }



        public override System.Guid AssignIdentity(CoffeeShop.OrderSummary.Models.Order document, string tenantId, Marten.Storage.IMartenDatabase database)
        {
            if (document.Id == Guid.Empty) _setter(document, Marten.Schema.Identity.CombGuidIdGeneration.NewGuid());
            return document.Id;
        }


        public override Marten.Internal.Operations.IStorageOperation Update(CoffeeShop.OrderSummary.Models.Order document, Marten.Internal.IMartenSession session, string tenant)
        {
            if (session.Concurrency == Marten.Services.ConcurrencyChecks.Disabled)
            {

                return new Marten.Generated.DocumentStorage.OverwriteOrderOperation60467594
                (
                    document, Identity(document),
                    null,
                    _document
                    
                );
            }

            else
            {

                return new Marten.Generated.DocumentStorage.UpdateOrderOperation60467594
                (
                    document, Identity(document),
                    null,
                    _document
                    
                );
            }

        }


        public override Marten.Internal.Operations.IStorageOperation Insert(CoffeeShop.OrderSummary.Models.Order document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.InsertOrderOperation60467594
            (
                document, Identity(document),
                null,
                _document
                
            );
        }


        public override Marten.Internal.Operations.IStorageOperation Upsert(CoffeeShop.OrderSummary.Models.Order document, Marten.Internal.IMartenSession session, string tenant)
        {
            if (session.Concurrency == Marten.Services.ConcurrencyChecks.Disabled)
            {

                return new Marten.Generated.DocumentStorage.OverwriteOrderOperation60467594
                (
                    document, Identity(document),
                    null,
                    _document
                    
                );
            }

            else
            {

                return new Marten.Generated.DocumentStorage.UpsertOrderOperation60467594
                (
                    document, Identity(document),
                    null,
                    _document
                    
                );
            }

        }


        public override Marten.Internal.Operations.IStorageOperation Overwrite(CoffeeShop.OrderSummary.Models.Order document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.OverwriteOrderOperation60467594
            (
                document, Identity(document),
                null,
                _document
                
            );

            return new Marten.Generated.DocumentStorage.OverwriteOrderOperation60467594
            (
                document, Identity(document),
                null,
                _document
                
            );
        }


        public override System.Guid Identity(CoffeeShop.OrderSummary.Models.Order document)
        {
            return document.Id;
        }


        public override Marten.Linq.Selectors.ISelector BuildSelector(Marten.Internal.IMartenSession session)
        {
            return new Marten.Generated.DocumentStorage.IdentityMapOrderSelector60467594(session, _document);
        }

    }

    // END: IdentityMapOrderDocumentStorage60467594
    
    
    // START: DirtyTrackingOrderDocumentStorage60467594
    public class DirtyTrackingOrderDocumentStorage60467594 : Marten.Internal.Storage.DirtyCheckedDocumentStorage<CoffeeShop.OrderSummary.Models.Order, System.Guid>
    {
        private readonly Marten.Schema.DocumentMapping _document;

        public DirtyTrackingOrderDocumentStorage60467594(Marten.Schema.DocumentMapping document) : base(document)
        {
            _document = document;
        }



        public override System.Guid AssignIdentity(CoffeeShop.OrderSummary.Models.Order document, string tenantId, Marten.Storage.IMartenDatabase database)
        {
            if (document.Id == Guid.Empty) _setter(document, Marten.Schema.Identity.CombGuidIdGeneration.NewGuid());
            return document.Id;
        }


        public override Marten.Internal.Operations.IStorageOperation Update(CoffeeShop.OrderSummary.Models.Order document, Marten.Internal.IMartenSession session, string tenant)
        {
            if (session.Concurrency == Marten.Services.ConcurrencyChecks.Disabled)
            {

                return new Marten.Generated.DocumentStorage.OverwriteOrderOperation60467594
                (
                    document, Identity(document),
                    null,
                    _document
                    
                );
            }

            else
            {

                return new Marten.Generated.DocumentStorage.UpdateOrderOperation60467594
                (
                    document, Identity(document),
                    null,
                    _document
                    
                );
            }

        }


        public override Marten.Internal.Operations.IStorageOperation Insert(CoffeeShop.OrderSummary.Models.Order document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.InsertOrderOperation60467594
            (
                document, Identity(document),
                null,
                _document
                
            );
        }


        public override Marten.Internal.Operations.IStorageOperation Upsert(CoffeeShop.OrderSummary.Models.Order document, Marten.Internal.IMartenSession session, string tenant)
        {
            if (session.Concurrency == Marten.Services.ConcurrencyChecks.Disabled)
            {

                return new Marten.Generated.DocumentStorage.OverwriteOrderOperation60467594
                (
                    document, Identity(document),
                    null,
                    _document
                    
                );
            }

            else
            {

                return new Marten.Generated.DocumentStorage.UpsertOrderOperation60467594
                (
                    document, Identity(document),
                    null,
                    _document
                    
                );
            }

        }


        public override Marten.Internal.Operations.IStorageOperation Overwrite(CoffeeShop.OrderSummary.Models.Order document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.OverwriteOrderOperation60467594
            (
                document, Identity(document),
                null,
                _document
                
            );

            return new Marten.Generated.DocumentStorage.OverwriteOrderOperation60467594
            (
                document, Identity(document),
                null,
                _document
                
            );
        }


        public override System.Guid Identity(CoffeeShop.OrderSummary.Models.Order document)
        {
            return document.Id;
        }


        public override Marten.Linq.Selectors.ISelector BuildSelector(Marten.Internal.IMartenSession session)
        {
            return new Marten.Generated.DocumentStorage.DirtyTrackingOrderSelector60467594(session, _document);
        }

    }

    // END: DirtyTrackingOrderDocumentStorage60467594
    
    
    // START: OrderBulkLoader60467594
    public class OrderBulkLoader60467594 : Marten.Internal.CodeGeneration.BulkLoader<CoffeeShop.OrderSummary.Models.Order, System.Guid>
    {
        private readonly Marten.Internal.Storage.IDocumentStorage<CoffeeShop.OrderSummary.Models.Order, System.Guid> _storage;

        public OrderBulkLoader60467594(Marten.Internal.Storage.IDocumentStorage<CoffeeShop.OrderSummary.Models.Order, System.Guid> storage) : base(storage)
        {
            _storage = storage;
        }


        public const string MAIN_LOADER_SQL = "COPY order_summary.mt_doc_order(\"mt_dotnet_type\", \"id\", \"mt_version\", \"data\") FROM STDIN BINARY";

        public const string TEMP_LOADER_SQL = "COPY mt_doc_order_temp(\"mt_dotnet_type\", \"id\", \"mt_version\", \"data\") FROM STDIN BINARY";

        public const string COPY_NEW_DOCUMENTS_SQL = "insert into order_summary.mt_doc_order (\"id\", \"data\", \"mt_dotnet_type\", \"mt_version\", mt_last_modified) (select mt_doc_order_temp.\"id\", mt_doc_order_temp.\"data\", mt_doc_order_temp.\"mt_dotnet_type\", mt_doc_order_temp.\"mt_version\", transaction_timestamp() from mt_doc_order_temp left join order_summary.mt_doc_order on mt_doc_order_temp.id = order_summary.mt_doc_order.id where order_summary.mt_doc_order.id is null)";

        public const string OVERWRITE_SQL = "update order_summary.mt_doc_order target SET data = source.data, mt_dotnet_type = source.mt_dotnet_type, mt_version = source.mt_version, mt_last_modified = transaction_timestamp() FROM mt_doc_order_temp source WHERE source.id = target.id";

        public const string CREATE_TEMP_TABLE_FOR_COPYING_SQL = "create temporary table mt_doc_order_temp as select * from order_summary.mt_doc_order limit 0";


        public override string CreateTempTableForCopying()
        {
            return CREATE_TEMP_TABLE_FOR_COPYING_SQL;
        }


        public override string CopyNewDocumentsFromTempTable()
        {
            return COPY_NEW_DOCUMENTS_SQL;
        }


        public override string OverwriteDuplicatesFromTempTable()
        {
            return OVERWRITE_SQL;
        }


        public override void LoadRow(Npgsql.NpgsqlBinaryImporter writer, CoffeeShop.OrderSummary.Models.Order document, Marten.Storage.Tenant tenant, Marten.ISerializer serializer)
        {
            writer.Write(document.GetType().FullName, NpgsqlTypes.NpgsqlDbType.Varchar);
            writer.Write(document.Id, NpgsqlTypes.NpgsqlDbType.Uuid);
            writer.Write(1, NpgsqlTypes.NpgsqlDbType.Integer);
            writer.Write(serializer.ToJson(document), NpgsqlTypes.NpgsqlDbType.Jsonb);
        }


        public override async System.Threading.Tasks.Task LoadRowAsync(Npgsql.NpgsqlBinaryImporter writer, CoffeeShop.OrderSummary.Models.Order document, Marten.Storage.Tenant tenant, Marten.ISerializer serializer, System.Threading.CancellationToken cancellation)
        {
            await writer.WriteAsync(document.GetType().FullName, NpgsqlTypes.NpgsqlDbType.Varchar, cancellation);
            await writer.WriteAsync(document.Id, NpgsqlTypes.NpgsqlDbType.Uuid, cancellation);
            await writer.WriteAsync(1, NpgsqlTypes.NpgsqlDbType.Integer, cancellation);
            await writer.WriteAsync(serializer.ToJson(document), NpgsqlTypes.NpgsqlDbType.Jsonb, cancellation);
        }


        public override string MainLoaderSql()
        {
            return MAIN_LOADER_SQL;
        }


        public override string TempLoaderSql()
        {
            return TEMP_LOADER_SQL;
        }

    }

    // END: OrderBulkLoader60467594
    
    
    // START: OrderProvider60467594
    public class OrderProvider60467594 : Marten.Internal.Storage.DocumentProvider<CoffeeShop.OrderSummary.Models.Order>
    {
        private readonly Marten.Schema.DocumentMapping _mapping;

        public OrderProvider60467594(Marten.Schema.DocumentMapping mapping) : base(new OrderBulkLoader60467594(new QueryOnlyOrderDocumentStorage60467594(mapping)), new QueryOnlyOrderDocumentStorage60467594(mapping), new LightweightOrderDocumentStorage60467594(mapping), new IdentityMapOrderDocumentStorage60467594(mapping), new DirtyTrackingOrderDocumentStorage60467594(mapping))
        {
            _mapping = mapping;
        }


    }

    // END: OrderProvider60467594
    
    
}

