if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('CELULA') and o.name = 'FK_CELULA_REFERENCE_PESSOA')
alter table CELULA
   drop constraint FK_CELULA_REFERENCE_PESSOA
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('CELULA') and o.name = 'FK_CELULA_REFERENCE_PESSOA')
alter table CELULA
   drop constraint FK_CELULA_REFERENCE_PESSOA
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('PESSOA') and o.name = 'FK_PESSOA_REFERENCE_CIDADE')
alter table PESSOA
   drop constraint FK_PESSOA_REFERENCE_CIDADE
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('PRESENTES') and o.name = 'FK_PRESENTE_REFERENCE_CELULA')
alter table PRESENTES
   drop constraint FK_PRESENTE_REFERENCE_CELULA
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('PRESENTES') and o.name = 'FK_PRESENTE_REFERENCE_PESSOA')
alter table PRESENTES
   drop constraint FK_PRESENTE_REFERENCE_PESSOA
go

if exists (select 1
            from  sysobjects
           where  id = object_id('CELULA')
            and   type = 'U')
   drop table CELULA
go

if exists (select 1
            from  sysobjects
           where  id = object_id('CIDADE')
            and   type = 'U')
   drop table CIDADE
go

if exists (select 1
            from  sysobjects
           where  id = object_id('PESSOA')
            and   type = 'U')
   drop table PESSOA
go

if exists (select 1
            from  sysobjects
           where  id = object_id('PRESENTES')
            and   type = 'U')
   drop table PRESENTES
go

/*==============================================================*/
/* Table: CELULA                                                */
/*==============================================================*/
create table CELULA (
   IDCELULA             int                  identity(1,1),
   IDANFITRIAO          int                  not null,
   IDPREGADOR           int                  not null,
   NOME                 varchar(200)         not null,
   DATA                 datetime             not null,
   HORA                 datetime             not null,
   constraint PK_CELULA primary key nonclustered (IDCELULA)
)
go

/*==============================================================*/
/* Table: CIDADE                                                */
/*==============================================================*/
create table CIDADE (
   IDCIDADE             int                  identity(1,1),
   NOME                 varchar(200)         null,
   ESTADO               varchar(2)           null,
   constraint PK_CIDADE primary key nonclustered (IDCIDADE)
)
go

/*==============================================================*/
/* Table: PESSOA                                                */
/*==============================================================*/
create table PESSOA (
   IDPESSOA             int                  identity(1,1),
   NOME                 varchar(200)         not null,
   ENDERECO             varchar(200)         not null,
   NRUA                 int                  not null,
   COMPLEMENTO          varchar(20)          null,
   BAIRRO               varchar(50)          not null,
   TELCELULAR           varchar(20)          null,
   TELFIXO              varchar(20)          null,
   EMAIL                varchar(50)          null,
   DATANASCIMENTO       datetime             not null,
   IDCIDADE             int                  not null,
   MEBROFREQUENTADOR    tinyint              not null,
   constraint PK_PESSOA primary key nonclustered (IDPESSOA)
)
go

/*==============================================================*/
/* Table: PRESENTES                                             */
/*==============================================================*/
create table PRESENTES (
   IDPRESENTE           int                  identity(1,1),
   IDCELULA             int                  not null,
   IDPESSOA             int                  not null,
   constraint PK_PRESENTES primary key nonclustered (IDPRESENTE)
)
go

alter table CELULA
   add constraint FK_CELULA_REFERENCE_PESSOA foreign key (IDANFITRIAO)
      references PESSOA (IDPESSOA)
go

alter table CELULA
   add constraint FK_CELULA_REFERENCE_PESSOA1 foreign key (IDPREGADOR)
      references PESSOA (IDPESSOA)
go

alter table PESSOA
   add constraint FK_PESSOA_REFERENCE_CIDADE foreign key (IDCIDADE)
      references CIDADE (IDCIDADE)
go

alter table PRESENTES
   add constraint FK_PRESENTE_REFERENCE_CELULA foreign key (IDCELULA)
      references CELULA (IDCELULA)
go

alter table PRESENTES
   add constraint FK_PRESENTE_REFERENCE_PESSOA2 foreign key (IDPESSOA)
      references PESSOA (IDPESSOA)
go
