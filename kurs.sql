PGDMP      #                |            kurs    16.4    16.4 "               0    0    ENCODING    ENCODING        SET client_encoding = 'UTF8';
                      false                       0    0 
   STDSTRINGS 
   STDSTRINGS     (   SET standard_conforming_strings = 'on';
                      false                       0    0 
   SEARCHPATH 
   SEARCHPATH     8   SELECT pg_catalog.set_config('search_path', '', false);
                      false                       1262    16465    kurs    DATABASE     |   CREATE DATABASE kurs WITH TEMPLATE = template0 ENCODING = 'UTF8' LOCALE_PROVIDER = libc LOCALE = 'Russian_Kazakhstan.1251';
    DROP DATABASE kurs;
                postgres    false            �            1259    16540    password    TABLE     �   CREATE TABLE public.password (
    "id заявителя" bigint,
    "id сотрудника" bigint,
    "пароль" text NOT NULL,
    "логин" text NOT NULL,
    "админ" boolean NOT NULL
);
    DROP TABLE public.password;
       public         heap    postgres    false                        0    0    TABLE password    ACL     2   GRANT ALL ON TABLE public.password TO "адмн";
          public          postgres    false    219            �            1259    16518    Акт    TABLE       CREATE TABLE public."Акт" (
    "Номер" numeric(7,0) NOT NULL,
    "ID ЗАГС" bigint NOT NULL,
    "ID заявителя" bigint NOT NULL,
    "Дата выдачи" date NOT NULL,
    CONSTRAINT "Дата выдачи" CHECK (("Дата выдачи" <= CURRENT_DATE))
);
    DROP TABLE public."Акт";
       public         heap    postgres    false            !           0    0    TABLE "Акт"    ACL     �   GRANT SELECT,INSERT,UPDATE ON TABLE public."Акт" TO "адмн";
GRANT SELECT ON TABLE public."Акт" TO "использователь";
GRANT SELECT,INSERT,UPDATE ON TABLE public."Акт" TO "менедж";
          public          postgres    false    218            �            1259    16466    ЗАГС    TABLE     �  CREATE TABLE public."ЗАГС" (
    "ID ЗАГС" bigint NOT NULL,
    "область" text NOT NULL,
    "город" text NOT NULL,
    "район" text NOT NULL,
    "наименование" text NOT NULL,
    "телефон" text NOT NULL,
    CONSTRAINT "город" CHECK (("город" ~ '^([А-Яа-я]+|[А-Яа-я]+-[А-Яа-я]+)$'::text)),
    CONSTRAINT "наименование" CHECK (("наименование" ~ '^[А-Яа-я]+$'::text)),
    CONSTRAINT "область" CHECK (("область" ~ '^[А-Яа-я]+$'::text)),
    CONSTRAINT "район" CHECK (("район" ~ '^[А-Яа-я]+$'::text)),
    CONSTRAINT "телефон" CHECK (("телефон" ~ '^[0-9]{11}$'::text))
);
    DROP TABLE public."ЗАГС";
       public         heap    postgres    false            "           0    0    TABLE "ЗАГС"    ACL     �   GRANT SELECT ON TABLE public."ЗАГС" TO goto;
GRANT SELECT,INSERT,DELETE,UPDATE ON TABLE public."ЗАГС" TO "адмн";
GRANT SELECT ON TABLE public."ЗАГС" TO "менедж";
          public          postgres    false    215            �            1259    16495    Заявитель    TABLE     �  CREATE TABLE public."Заявитель" (
    "Фамилия" text NOT NULL,
    "Имя" text NOT NULL,
    "Отчество" text,
    "ID заявителя" bigint NOT NULL,
    "ID сотрудника" bigint NOT NULL,
    "Серия паспорта" numeric(4,0) NOT NULL,
    "Номер паспорта" numeric(6,0) NOT NULL,
    "телефон" text,
    "свид. о браке" text,
    "Дата рождения" date NOT NULL,
    "свид. о рождении" text NOT NULL,
    CONSTRAINT "Дата рождения" CHECK (("Дата рождения" <= (CURRENT_DATE - '16 years'::interval))),
    CONSTRAINT "Имя" CHECK (("Имя" ~ '^[А-Яа-я]+$'::text)),
    CONSTRAINT "Отчество" CHECK (("Отчество" ~ '^[А-Яа-я]+$'::text)),
    CONSTRAINT "Фамилия" CHECK (("Фамилия" ~ '^([А-Яа-я]+|[А-Яа-я]+-[А-Яа-я]+)$'::text)),
    CONSTRAINT "телефон" CHECK (("телефон" ~ '^[0-9]{11}$'::text))
);
 (   DROP TABLE public."Заявитель";
       public         heap    postgres    false            #           0    0    TABLE "Заявитель"    ACL     �   GRANT SELECT,INSERT,UPDATE ON TABLE public."Заявитель" TO "адмн";
GRANT SELECT ON TABLE public."Заявитель" TO "использователь";
GRANT SELECT,INSERT,UPDATE ON TABLE public."Заявитель" TO "менедж";
          public          postgres    false    217            �            1259    16478    Сотрудники    TABLE     �  CREATE TABLE public."Сотрудники" (
    "ID сотрудника" bigint NOT NULL,
    "ID загс" bigint NOT NULL,
    "Фамилия" text NOT NULL,
    "Имя" text NOT NULL,
    "Отчество" text,
    "телефон" text NOT NULL,
    "Должность" text NOT NULL,
    CONSTRAINT "Должность" CHECK (("Должность" ~ '^[А-Яа-я]+$'::text)),
    CONSTRAINT "Имя" CHECK (("Имя" ~ '^[А-Яа-я]+$'::text)),
    CONSTRAINT "Отчество" CHECK (("Отчество" ~ '^[А-Яа-я]+$'::text)),
    CONSTRAINT "Фамилия" CHECK (("Фамилия" ~ '^([А-Яа-я]+|[А-Яа-я]+-[А-Яа-я]+)$'::text)),
    CONSTRAINT "телефон" CHECK (("телефон" ~ '^[0-9]{11}$'::text))
);
 *   DROP TABLE public."Сотрудники";
       public         heap    postgres    false            $           0    0    TABLE "Сотрудники"    ACL     �   GRANT SELECT,INSERT,DELETE,UPDATE ON TABLE public."Сотрудники" TO "адмн";
GRANT SELECT ON TABLE public."Сотрудники" TO "менедж";
          public          postgres    false    216                      0    16540    password 
   TABLE DATA           �   COPY public.password ("id заявителя", "id сотрудника", "пароль", "логин", "админ") FROM stdin;
    public          postgres    false    219   �3                 0    16518    Акт 
   TABLE DATA           q   COPY public."Акт" ("Номер", "ID ЗАГС", "ID заявителя", "Дата выдачи") FROM stdin;
    public          postgres    false    218   �3                 0    16466    ЗАГС 
   TABLE DATA           �   COPY public."ЗАГС" ("ID ЗАГС", "область", "город", "район", "наименование", "телефон") FROM stdin;
    public          postgres    false    215   4                 0    16495    Заявитель 
   TABLE DATA           ;  COPY public."Заявитель" ("Фамилия", "Имя", "Отчество", "ID заявителя", "ID сотрудника", "Серия паспорта", "Номер паспорта", "телефон", "свид. о браке", "Дата рождения", "свид. о рождении") FROM stdin;
    public          postgres    false    217   �4                 0    16478    Сотрудники 
   TABLE DATA           �   COPY public."Сотрудники" ("ID сотрудника", "ID загс", "Фамилия", "Имя", "Отчество", "телефон", "Должность") FROM stdin;
    public          postgres    false    216   a5       |           2606    16523    Акт akt_nomer_pk 
   CONSTRAINT     ]   ALTER TABLE ONLY public."Акт"
    ADD CONSTRAINT akt_nomer_pk PRIMARY KEY ("Номер");
 ?   ALTER TABLE ONLY public."Акт" DROP CONSTRAINT akt_nomer_pk;
       public            postgres    false    218            ~           2606    16559    password login_pk 
   CONSTRAINT     Y   ALTER TABLE ONLY public.password
    ADD CONSTRAINT login_pk PRIMARY KEY ("логин");
 ;   ALTER TABLE ONLY public.password DROP CONSTRAINT login_pk;
       public            postgres    false    219            r           2606    16489    Сотрудники sotr_pk 
   CONSTRAINT     s   ALTER TABLE ONLY public."Сотрудники"
    ADD CONSTRAINT sotr_pk PRIMARY KEY ("ID сотрудника");
 H   ALTER TABLE ONLY public."Сотрудники" DROP CONSTRAINT sotr_pk;
       public            postgres    false    216            p           2606    16477    ЗАГС zags 
   CONSTRAINT     X   ALTER TABLE ONLY public."ЗАГС"
    ADD CONSTRAINT zags PRIMARY KEY ("ID ЗАГС");
 9   ALTER TABLE ONLY public."ЗАГС" DROP CONSTRAINT zags;
       public            postgres    false    215            t           2606    16506    Заявитель zayav_pk 
   CONSTRAINT     p   ALTER TABLE ONLY public."Заявитель"
    ADD CONSTRAINT zayav_pk PRIMARY KEY ("ID заявителя");
 G   ALTER TABLE ONLY public."Заявитель" DROP CONSTRAINT zayav_pk;
       public            postgres    false    217            v           2606    16508    Заявитель Брак 
   CONSTRAINT     o   ALTER TABLE ONLY public."Заявитель"
    ADD CONSTRAINT "Брак" UNIQUE ("свид. о браке");
 I   ALTER TABLE ONLY public."Заявитель" DROP CONSTRAINT "Брак";
       public            postgres    false    217            x           2606    16510 !   Заявитель Паспорт 
   CONSTRAINT     �   ALTER TABLE ONLY public."Заявитель"
    ADD CONSTRAINT "Паспорт" UNIQUE ("Серия паспорта", "Номер паспорта");
 O   ALTER TABLE ONLY public."Заявитель" DROP CONSTRAINT "Паспорт";
       public            postgres    false    217    217            z           2606    16512 #   Заявитель Рождение 
   CONSTRAINT     }   ALTER TABLE ONLY public."Заявитель"
    ADD CONSTRAINT "Рождение" UNIQUE ("свид. о рождении");
 Q   ALTER TABLE ONLY public."Заявитель" DROP CONSTRAINT "Рождение";
       public            postgres    false    217            �           2606    16524    Акт akt_zags_fk    FK CONSTRAINT     �   ALTER TABLE ONLY public."Акт"
    ADD CONSTRAINT akt_zags_fk FOREIGN KEY ("ID ЗАГС") REFERENCES public."ЗАГС"("ID ЗАГС");
 >   ALTER TABLE ONLY public."Акт" DROP CONSTRAINT akt_zags_fk;
       public          postgres    false    215    218    4720            �           2606    16529    Акт akt_zayav_fk    FK CONSTRAINT     �   ALTER TABLE ONLY public."Акт"
    ADD CONSTRAINT akt_zayav_fk FOREIGN KEY ("ID заявителя") REFERENCES public."Заявитель"("ID заявителя");
 ?   ALTER TABLE ONLY public."Акт" DROP CONSTRAINT akt_zayav_fk;
       public          postgres    false    218    4724    217            �           2606    16553    password id_sotr_fk    FK CONSTRAINT     �   ALTER TABLE ONLY public.password
    ADD CONSTRAINT id_sotr_fk FOREIGN KEY ("id сотрудника") REFERENCES public."Сотрудники"("ID сотрудника");
 =   ALTER TABLE ONLY public.password DROP CONSTRAINT id_sotr_fk;
       public          postgres    false    216    4722    219            �           2606    16548    password id_zaya_fk    FK CONSTRAINT     �   ALTER TABLE ONLY public.password
    ADD CONSTRAINT id_zaya_fk FOREIGN KEY ("id заявителя") REFERENCES public."Заявитель"("ID заявителя");
 =   ALTER TABLE ONLY public.password DROP CONSTRAINT id_zaya_fk;
       public          postgres    false    219    217    4724                       2606    16490 !   Сотрудники sotr_zags_fk    FK CONSTRAINT     �   ALTER TABLE ONLY public."Сотрудники"
    ADD CONSTRAINT sotr_zags_fk FOREIGN KEY ("ID загс") REFERENCES public."ЗАГС"("ID ЗАГС");
 M   ALTER TABLE ONLY public."Сотрудники" DROP CONSTRAINT sotr_zags_fk;
       public          postgres    false    4720    216    215            �           2606    16513     Заявитель zayav_sotr_fk    FK CONSTRAINT     �   ALTER TABLE ONLY public."Заявитель"
    ADD CONSTRAINT zayav_sotr_fk FOREIGN KEY ("ID сотрудника") REFERENCES public."Сотрудники"("ID сотрудника");
 L   ALTER TABLE ONLY public."Заявитель" DROP CONSTRAINT zayav_sotr_fk;
       public          postgres    false    217    216    4722                       3256    16535    ЗАГС pol    POLICY     ;   CREATE POLICY pol ON public."ЗАГС" FOR SELECT TO goto;
 &   DROP POLICY pol ON public."ЗАГС";
       public          postgres    false    215               >   x����4�L2�L63OJ3�4K417�0�4L51J37337HNMJ�,�L/*�LN�,����� ��%         3   x�3�4�4�4202�50".#��1B����Es�p!\��+F��� ��/         {   x���A
@PE��-F�^Y��`��20S� �����L|)�w���(tرI���Th�J.��R\��B�Z۳Xű�3�f�)���ĵH~Ǝ%$�e9ߎ��מ9���&<ML�GD,��         �   x�U�1�0Eg�.E�SA�Y`�XXW�*!AQ9�ύ�Kd���W�g+���ɞpE��=��#�(��L���WEb�Ʒb�4�vj]� �e�C>H>	7��1���)-M��b��¯6G�F9���ZD9^n��ء�Y�l.�z��]�Z��'^2�M�����_�n�� 1���         �   x�}�K�0D��aP�4��p�4u�!$�P�z��0�~�z��O#'���P�U/F."���ZcMFx��Q�74�UJ�s?�G�DZ�I����(���p6sNFf���%��s��C�኎s�w�w��4Q̖p���{�S��ɨ~~���� P��+��l�     