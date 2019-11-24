delete from Membros
delete from Funcionarios
delete from Perfis

delete from Funcionalidades
insert into Funcionalidades (Descricao) Values ('CADASTRO DE FUNCIONARIO')
insert into Funcionalidades (Descricao) Values ('CADASTRO DE PERFIS')
insert into Funcionalidades (Descricao) Values ('CADASTRO DE USUARIO')
insert into Funcionalidades (Descricao) Values ('CADASTRO DE MEMBRO')
insert into Funcionalidades (Descricao) Values ('FICHA DE CADASTRO DE MEMBRO')



delete from PesoGrupos
insert into PesoGrupos (DiaHorario, Peso) Values ('SegundaManhã',11)
insert into PesoGrupos (DiaHorario, Peso) Values ('SegundaTarde',12)
insert into PesoGrupos (DiaHorario, Peso) Values ('SegundaNoite',13)
insert into PesoGrupos (DiaHorario, Peso) Values ('TerçaManhã',21)
insert into PesoGrupos (DiaHorario, Peso) Values ('TerçaTarde',22)
insert into PesoGrupos (DiaHorario, Peso) Values ('TerçaNoite',23)
insert into PesoGrupos (DiaHorario, Peso) Values ('QuartaManhã',31)
insert into PesoGrupos (DiaHorario, Peso) Values ('QuartaTarde',32)
insert into PesoGrupos (DiaHorario, Peso) Values ('QuartaNoite',33)
insert into PesoGrupos (DiaHorario, Peso) Values ('QuintaManhã',41)
insert into PesoGrupos (DiaHorario, Peso) Values ('QuintaTarde',42)
insert into PesoGrupos (DiaHorario, Peso) Values ('QuintaNoite',43)
insert into PesoGrupos (DiaHorario, Peso) Values ('SextaManhã',51)
insert into PesoGrupos (DiaHorario, Peso) Values ('SextaTarde',52)
insert into PesoGrupos (DiaHorario, Peso) Values ('SextaNoite',53)
insert into PesoGrupos (DiaHorario, Peso) Values ('SábadoManhã',61)
insert into PesoGrupos (DiaHorario, Peso) Values ('SábadoTarde',62)
insert into PesoGrupos (DiaHorario, Peso) Values ('SábadoNoite',63)
insert into PesoGrupos (DiaHorario, Peso) Values ('DomingoManhã',71)
insert into PesoGrupos (DiaHorario, Peso) Values ('DomingoTarde',72)
insert into PesoGrupos (DiaHorario, Peso) Values ('DomingoNoite',73)