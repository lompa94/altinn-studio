using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Newtonsoft.Json;

namespace App.IntegrationTests.Mocks.Apps.tdd.frontendtest
{
public class Skjema{
[Range(Int32.MinValue,Int32.MaxValue)]
    [XmlAttribute("skjemanummer")]
    [BindNever]
public decimal skjemanummer {get; set;} = 1533;
[Range(Int32.MinValue,Int32.MaxValue)]
    [XmlAttribute("spesifikasjonsnummer")]
    [BindNever]
public decimal spesifikasjonsnummer {get; set;} = 11172;
    [XmlAttribute("blankettnummer")]
    [BindNever]
public  string blankettnummer {get; set; } = "RF-1453";
    [XmlAttribute("tittel")]
    [BindNever]
public  string tittel {get; set; } = "Endring av navn";
[Range(1,Int32.MaxValue)]
    [XmlAttribute("gruppeid")]
    [BindNever]
public decimal gruppeid {get; set;} = 9308;
    [XmlAttribute("etatid")]
public string etatid { get; set; }
    [XmlElement("Innledning-grp-9309")]
    [JsonProperty("Innledning-grp-9309")]
    [JsonPropertyName("Innledning-grp-9309")]
public Innledninggrp9309 Innledninggrp9309 { get; set; }
    [XmlElement("NyttNavn-grp-9313")]
    [JsonProperty("NyttNavn-grp-9313")]
    [JsonPropertyName("NyttNavn-grp-9313")]
public NyttNavngrp9313 NyttNavngrp9313 { get; set; }
    [XmlElement("Tilknytning-grp-9315")]
    [JsonProperty("Tilknytning-grp-9315")]
    [JsonPropertyName("Tilknytning-grp-9315")]
public Tilknytninggrp9315 Tilknytninggrp9315 { get; set; }
    [XmlElement("Begrunnelse-grp-9317")]
    [JsonProperty("Begrunnelse-grp-9317")]
    [JsonPropertyName("Begrunnelse-grp-9317")]
public Begrunnelsegrp9317 Begrunnelsegrp9317 { get; set; }
    [XmlElement("Radioknapp")]
    [JsonProperty("Radioknapp")]
    [JsonPropertyName("Radioknapp")]
public string Radioknapp { get; set; }
}
public class Innledninggrp9309{
[Range(1,Int32.MaxValue)]
    [XmlAttribute("gruppeid")]
    [BindNever]
public decimal gruppeid {get; set;} = 9309;
    [XmlElement("NavneendringenGjelderFor-grp-9310")]
    [JsonProperty("NavneendringenGjelderFor-grp-9310")]
    [JsonPropertyName("NavneendringenGjelderFor-grp-9310")]
public NavneendringenGjelderForgrp9310 NavneendringenGjelderForgrp9310 { get; set; }
    [XmlElement("Signerer-grp-9320")]
    [JsonProperty("Signerer-grp-9320")]
    [JsonPropertyName("Signerer-grp-9320")]
public Signerergrp9320 Signerergrp9320 { get; set; }
    [XmlElement("TredjeSignerer-grp-9349")]
    [JsonProperty("TredjeSignerer-grp-9349")]
    [JsonPropertyName("TredjeSignerer-grp-9349")]
public TredjeSignerergrp9349 TredjeSignerergrp9349 { get; set; }
    [XmlElement("Kontaktinformasjon-grp-9311")]
    [JsonProperty("Kontaktinformasjon-grp-9311")]
    [JsonPropertyName("Kontaktinformasjon-grp-9311")]
public Kontaktinformasjongrp9311 Kontaktinformasjongrp9311 { get; set; }
    [XmlElement("SamtykkeTilElektroniskKommunikasjon-grp-9312")]
    [JsonProperty("SamtykkeTilElektroniskKommunikasjon-grp-9312")]
    [JsonPropertyName("SamtykkeTilElektroniskKommunikasjon-grp-9312")]
public SamtykkeTilElektroniskKommunikasjongrp9312 SamtykkeTilElektroniskKommunikasjongrp9312 { get; set; }
}
public class NavneendringenGjelderForgrp9310{
[Range(1,Int32.MaxValue)]
    [XmlAttribute("gruppeid")]
    [BindNever]
public decimal gruppeid {get; set;} = 9310;
    [XmlElement("MeldingMeldingsmottakerFodselsnummer-datadef-33548")]
    [JsonProperty("MeldingMeldingsmottakerFodselsnummer-datadef-33548")]
    [JsonPropertyName("MeldingMeldingsmottakerFodselsnummer-datadef-33548")]
public MeldingMeldingsmottakerFodselsnummerdatadef33548 MeldingMeldingsmottakerFodselsnummerdatadef33548 { get; set; }
    [XmlElement("SubjektFodselsnummer-datadef-34727")]
    [JsonProperty("SubjektFodselsnummer-datadef-34727")]
    [JsonPropertyName("SubjektFodselsnummer-datadef-34727")]
public SubjektFodselsnummerdatadef34727 SubjektFodselsnummerdatadef34727 { get; set; }
    [XmlElement("SubjektFornavnFolkeregistrert-datadef-34730")]
    [JsonProperty("SubjektFornavnFolkeregistrert-datadef-34730")]
    [JsonPropertyName("SubjektFornavnFolkeregistrert-datadef-34730")]
public SubjektFornavnFolkeregistrertdatadef34730 SubjektFornavnFolkeregistrertdatadef34730 { get; set; }
    [XmlElement("SubjektMellomnavnFolkeregistrert-datadef-34731")]
    [JsonProperty("SubjektMellomnavnFolkeregistrert-datadef-34731")]
    [JsonPropertyName("SubjektMellomnavnFolkeregistrert-datadef-34731")]
public SubjektMellomnavnFolkeregistrertdatadef34731 SubjektMellomnavnFolkeregistrertdatadef34731 { get; set; }
    [XmlElement("SubjektEtternavnFolkeregistrert-datadef-34729")]
    [JsonProperty("SubjektEtternavnFolkeregistrert-datadef-34729")]
    [JsonPropertyName("SubjektEtternavnFolkeregistrert-datadef-34729")]
public SubjektEtternavnFolkeregistrertdatadef34729 SubjektEtternavnFolkeregistrertdatadef34729 { get; set; }
}
public class MeldingMeldingsmottakerFodselsnummerdatadef33548{
[Range(1,Int32.MaxValue)]
    [XmlAttribute("orid")]
    [BindNever]
public decimal orid {get; set;} = 33548;
    [XmlText()]
public string value { get; set; }
}
public class SubjektFodselsnummerdatadef34727{
[Range(1,Int32.MaxValue)]
    [XmlAttribute("orid")]
    [BindNever]
public decimal orid {get; set;} = 34727;
    [XmlText()]
public string value { get; set; }
}
public class SubjektFornavnFolkeregistrertdatadef34730{
[Range(1,Int32.MaxValue)]
    [XmlAttribute("orid")]
    [BindNever]
public decimal orid {get; set;} = 34730;
[MinLength(1)]
[MaxLength(60)]
    [XmlText()]
public string value { get; set; }
}
public class SubjektMellomnavnFolkeregistrertdatadef34731{
[Range(1,Int32.MaxValue)]
    [XmlAttribute("orid")]
    [BindNever]
public decimal orid {get; set;} = 34731;
[MinLength(1)]
[MaxLength(60)]
    [XmlText()]
public string value { get; set; }
}
public class SubjektEtternavnFolkeregistrertdatadef34729{
[Range(1,Int32.MaxValue)]
    [XmlAttribute("orid")]
    [BindNever]
public decimal orid {get; set;} = 34729;
[MinLength(1)]
[MaxLength(60)]
    [XmlText()]
public string value { get; set; }
}
public class Signerergrp9320{
[Range(1,Int32.MaxValue)]
    [XmlAttribute("gruppeid")]
    [BindNever]
public decimal gruppeid {get; set;} = 9320;
    [XmlElement("SignererEkstraFodselsnummer-datadef-34744")]
    [JsonProperty("SignererEkstraFodselsnummer-datadef-34744")]
    [JsonPropertyName("SignererEkstraFodselsnummer-datadef-34744")]
public SignererEkstraFodselsnummerdatadef34744 SignererEkstraFodselsnummerdatadef34744 { get; set; }
    [XmlElement("SignererEkstraEtternavn-datadef-34745")]
    [JsonProperty("SignererEkstraEtternavn-datadef-34745")]
    [JsonPropertyName("SignererEkstraEtternavn-datadef-34745")]
public SignererEkstraEtternavndatadef34745 SignererEkstraEtternavndatadef34745 { get; set; }
    [XmlElement("SignererEkstraFornavn-datadef-34746")]
    [JsonProperty("SignererEkstraFornavn-datadef-34746")]
    [JsonPropertyName("SignererEkstraFornavn-datadef-34746")]
public SignererEkstraFornavndatadef34746 SignererEkstraFornavndatadef34746 { get; set; }
    [XmlElement("SignererEkstraMellomnavn-datadef-34747")]
    [JsonProperty("SignererEkstraMellomnavn-datadef-34747")]
    [JsonPropertyName("SignererEkstraMellomnavn-datadef-34747")]
public SignererEkstraMellomnavndatadef34747 SignererEkstraMellomnavndatadef34747 { get; set; }
    [XmlElement("SignererEkstraEpost-datadef-34749")]
    [JsonProperty("SignererEkstraEpost-datadef-34749")]
    [JsonPropertyName("SignererEkstraEpost-datadef-34749")]
public SignererEkstraEpostdatadef34749 SignererEkstraEpostdatadef34749 { get; set; }
    [XmlElement("SignererEkstraMobiltelefonsnummer-datadef-34750")]
    [JsonProperty("SignererEkstraMobiltelefonsnummer-datadef-34750")]
    [JsonPropertyName("SignererEkstraMobiltelefonsnummer-datadef-34750")]
public SignererEkstraMobiltelefonsnummerdatadef34750 SignererEkstraMobiltelefonsnummerdatadef34750 { get; set; }
    [XmlElement("SignererEkstraReferanseAltinn-datadef-34751")]
    [JsonProperty("SignererEkstraReferanseAltinn-datadef-34751")]
    [JsonPropertyName("SignererEkstraReferanseAltinn-datadef-34751")]
public SignererEkstraReferanseAltinndatadef34751 SignererEkstraReferanseAltinndatadef34751 { get; set; }
    [XmlElement("SignererEkstraArkivDato-datadef-34752")]
    [JsonProperty("SignererEkstraArkivDato-datadef-34752")]
    [JsonPropertyName("SignererEkstraArkivDato-datadef-34752")]
public SignererEkstraArkivDatodatadef34752 SignererEkstraArkivDatodatadef34752 { get; set; }
    [XmlElement("SignererEkstraTidspunkt-datadef-34753")]
    [JsonProperty("SignererEkstraTidspunkt-datadef-34753")]
    [JsonPropertyName("SignererEkstraTidspunkt-datadef-34753")]
public SignererEkstraTidspunktdatadef34753 SignererEkstraTidspunktdatadef34753 { get; set; }
    [XmlElement("SignererEkstraAksept-datadef-34754")]
    [JsonProperty("SignererEkstraAksept-datadef-34754")]
    [JsonPropertyName("SignererEkstraAksept-datadef-34754")]
public SignererEkstraAkseptdatadef34754 SignererEkstraAkseptdatadef34754 { get; set; }
    [XmlElement("SignererEkstraMalform-datadef-34895")]
    [JsonProperty("SignererEkstraMalform-datadef-34895")]
    [JsonPropertyName("SignererEkstraMalform-datadef-34895")]
public SignererEkstraMalformdatadef34895 SignererEkstraMalformdatadef34895 { get; set; }
}
public class SignererEkstraFodselsnummerdatadef34744{
[Range(1,Int32.MaxValue)]
    [XmlAttribute("orid")]
    [BindNever]
public decimal orid {get; set;} = 34744;
    [XmlText()]
public string value { get; set; }
}
public class SignererEkstraEtternavndatadef34745{
[Range(1,Int32.MaxValue)]
    [XmlAttribute("orid")]
    [BindNever]
public decimal orid {get; set;} = 34745;
[MinLength(1)]
[MaxLength(60)]
    [XmlText()]
public string value { get; set; }
}
public class SignererEkstraFornavndatadef34746{
[Range(1,Int32.MaxValue)]
    [XmlAttribute("orid")]
    [BindNever]
public decimal orid {get; set;} = 34746;
[MinLength(1)]
[MaxLength(60)]
    [XmlText()]
public string value { get; set; }
}
public class SignererEkstraMellomnavndatadef34747{
[Range(1,Int32.MaxValue)]
    [XmlAttribute("orid")]
    [BindNever]
public decimal orid {get; set;} = 34747;
[MinLength(1)]
[MaxLength(60)]
    [XmlText()]
public string value { get; set; }
}
public class SignererEkstraEpostdatadef34749{
[Range(1,Int32.MaxValue)]
    [XmlAttribute("orid")]
    [BindNever]
public decimal orid {get; set;} = 34749;
[MinLength(1)]
[MaxLength(50)]
    [XmlText()]
public string value { get; set; }
}
public class SignererEkstraMobiltelefonsnummerdatadef34750{
[Range(1,Int32.MaxValue)]
    [XmlAttribute("orid")]
    [BindNever]
public decimal orid {get; set;} = 34750;
[MinLength(1)]
[MaxLength(15)]
    [XmlText()]
public string value { get; set; }
}
public class SignererEkstraReferanseAltinndatadef34751{
[Range(1,Int32.MaxValue)]
    [XmlAttribute("orid")]
    [BindNever]
public decimal orid {get; set;} = 34751;
[MinLength(1)]
[MaxLength(10)]
    [XmlText()]
public string value { get; set; }
}
public class SignererEkstraArkivDatodatadef34752{
[Range(1,Int32.MaxValue)]
    [XmlAttribute("orid")]
    [BindNever]
public decimal orid {get; set;} = 34752;
    [XmlText()]
public DateTime value { get; set; }
}
public class SignererEkstraTidspunktdatadef34753{
[Range(1,Int32.MaxValue)]
    [XmlAttribute("orid")]
    [BindNever]
public decimal orid {get; set;} = 34753;
[RegularExpression(@"^([0,1][0-9]|[2][0-3]):[0-5][0-9]:[0-5][0-9](Z|(\+|-)([0,1][0-9]|[2][0-3]):[0-5][0-9])?$")]
    [XmlText()]
public string value { get; set; }
}
public class SignererEkstraAkseptdatadef34754{
[Range(1,Int32.MaxValue)]
    [XmlAttribute("orid")]
    [BindNever]
public decimal orid {get; set;} = 34754;
[RegularExpression(@"(J|N)")]
    [XmlText()]
public string value { get; set; }
}
public class SignererEkstraMalformdatadef34895{
[Range(1,Int32.MaxValue)]
    [XmlAttribute("orid")]
    [BindNever]
public decimal orid {get; set;} = 34895;
[MinLength(1)]
[MaxLength(10)]
    [XmlText()]
public string value { get; set; }
}
public class TredjeSignerergrp9349{
[Range(1,Int32.MaxValue)]
    [XmlAttribute("gruppeid")]
    [BindNever]
public decimal gruppeid {get; set;} = 9349;
    [XmlElement("SignererTredjeFodselsnummer-datadef-34884")]
    [JsonProperty("SignererTredjeFodselsnummer-datadef-34884")]
    [JsonPropertyName("SignererTredjeFodselsnummer-datadef-34884")]
public SignererTredjeFodselsnummerdatadef34884 SignererTredjeFodselsnummerdatadef34884 { get; set; }
    [XmlElement("SignererTredjeEtternavn-datadef-34885")]
    [JsonProperty("SignererTredjeEtternavn-datadef-34885")]
    [JsonPropertyName("SignererTredjeEtternavn-datadef-34885")]
public SignererTredjeEtternavndatadef34885 SignererTredjeEtternavndatadef34885 { get; set; }
    [XmlElement("SignererTredjeFornavn-datadef-34886")]
    [JsonProperty("SignererTredjeFornavn-datadef-34886")]
    [JsonPropertyName("SignererTredjeFornavn-datadef-34886")]
public SignererTredjeFornavndatadef34886 SignererTredjeFornavndatadef34886 { get; set; }
    [XmlElement("SignererTredjeMellomnavn-datadef-34887")]
    [JsonProperty("SignererTredjeMellomnavn-datadef-34887")]
    [JsonPropertyName("SignererTredjeMellomnavn-datadef-34887")]
public SignererTredjeMellomnavndatadef34887 SignererTredjeMellomnavndatadef34887 { get; set; }
    [XmlElement("SignererTredjeEpost-datadef-34889")]
    [JsonProperty("SignererTredjeEpost-datadef-34889")]
    [JsonPropertyName("SignererTredjeEpost-datadef-34889")]
public SignererTredjeEpostdatadef34889 SignererTredjeEpostdatadef34889 { get; set; }
    [XmlElement("SignererTredjeMobiltelefonnummer-datadef-34890")]
    [JsonProperty("SignererTredjeMobiltelefonnummer-datadef-34890")]
    [JsonPropertyName("SignererTredjeMobiltelefonnummer-datadef-34890")]
public SignererTredjeMobiltelefonnummerdatadef34890 SignererTredjeMobiltelefonnummerdatadef34890 { get; set; }
    [XmlElement("SignererTredjeReferanseAltinn-datadef-34891")]
    [JsonProperty("SignererTredjeReferanseAltinn-datadef-34891")]
    [JsonPropertyName("SignererTredjeReferanseAltinn-datadef-34891")]
public SignererTredjeReferanseAltinndatadef34891 SignererTredjeReferanseAltinndatadef34891 { get; set; }
    [XmlElement("SignererTredjeArkivDato-datadef-34892")]
    [JsonProperty("SignererTredjeArkivDato-datadef-34892")]
    [JsonPropertyName("SignererTredjeArkivDato-datadef-34892")]
public SignererTredjeArkivDatodatadef34892 SignererTredjeArkivDatodatadef34892 { get; set; }
    [XmlElement("SignererTredjeTidspunkt-datadef-34893")]
    [JsonProperty("SignererTredjeTidspunkt-datadef-34893")]
    [JsonPropertyName("SignererTredjeTidspunkt-datadef-34893")]
public SignererTredjeTidspunktdatadef34893 SignererTredjeTidspunktdatadef34893 { get; set; }
    [XmlElement("SignererTredjeAksept-datadef-34894")]
    [JsonProperty("SignererTredjeAksept-datadef-34894")]
    [JsonPropertyName("SignererTredjeAksept-datadef-34894")]
public SignererTredjeAkseptdatadef34894 SignererTredjeAkseptdatadef34894 { get; set; }
    [XmlElement("SignererTredjeMalform-datadef-34883")]
    [JsonProperty("SignererTredjeMalform-datadef-34883")]
    [JsonPropertyName("SignererTredjeMalform-datadef-34883")]
public SignererTredjeMalformdatadef34883 SignererTredjeMalformdatadef34883 { get; set; }
}
public class SignererTredjeFodselsnummerdatadef34884{
[Range(1,Int32.MaxValue)]
    [XmlAttribute("orid")]
    [BindNever]
public decimal orid {get; set;} = 34884;
    [XmlText()]
public string value { get; set; }
}
public class SignererTredjeEtternavndatadef34885{
[Range(1,Int32.MaxValue)]
    [XmlAttribute("orid")]
    [BindNever]
public decimal orid {get; set;} = 34885;
[MinLength(1)]
[MaxLength(60)]
    [XmlText()]
public string value { get; set; }
}
public class SignererTredjeFornavndatadef34886{
[Range(1,Int32.MaxValue)]
    [XmlAttribute("orid")]
    [BindNever]
public decimal orid {get; set;} = 34886;
[MinLength(1)]
[MaxLength(60)]
    [XmlText()]
public string value { get; set; }
}
public class SignererTredjeMellomnavndatadef34887{
[Range(1,Int32.MaxValue)]
    [XmlAttribute("orid")]
    [BindNever]
public decimal orid {get; set;} = 34887;
[MinLength(1)]
[MaxLength(60)]
    [XmlText()]
public string value { get; set; }
}
public class SignererTredjeEpostdatadef34889{
[Range(1,Int32.MaxValue)]
    [XmlAttribute("orid")]
    [BindNever]
public decimal orid {get; set;} = 34889;
[MinLength(1)]
[MaxLength(50)]
    [XmlText()]
public string value { get; set; }
}
public class SignererTredjeMobiltelefonnummerdatadef34890{
[Range(1,Int32.MaxValue)]
    [XmlAttribute("orid")]
    [BindNever]
public decimal orid {get; set;} = 34890;
[MinLength(1)]
[MaxLength(15)]
    [XmlText()]
public string value { get; set; }
}
public class SignererTredjeReferanseAltinndatadef34891{
[Range(1,Int32.MaxValue)]
    [XmlAttribute("orid")]
    [BindNever]
public decimal orid {get; set;} = 34891;
[MinLength(1)]
[MaxLength(10)]
    [XmlText()]
public string value { get; set; }
}
public class SignererTredjeArkivDatodatadef34892{
[Range(1,Int32.MaxValue)]
    [XmlAttribute("orid")]
    [BindNever]
public decimal orid {get; set;} = 34892;
    [XmlText()]
public DateTime value { get; set; }
}
public class SignererTredjeTidspunktdatadef34893{
[Range(1,Int32.MaxValue)]
    [XmlAttribute("orid")]
    [BindNever]
public decimal orid {get; set;} = 34893;
[RegularExpression(@"^([0,1][0-9]|[2][0-3]):[0-5][0-9]:[0-5][0-9](Z|(\+|-)([0,1][0-9]|[2][0-3]):[0-5][0-9])?$")]
    [XmlText()]
public string value { get; set; }
}
public class SignererTredjeAkseptdatadef34894{
[Range(1,Int32.MaxValue)]
    [XmlAttribute("orid")]
    [BindNever]
public decimal orid {get; set;} = 34894;
[RegularExpression(@"(J|N)")]
    [XmlText()]
public string value { get; set; }
}
public class SignererTredjeMalformdatadef34883{
[Range(1,Int32.MaxValue)]
    [XmlAttribute("orid")]
    [BindNever]
public decimal orid {get; set;} = 34883;
[MinLength(1)]
[MaxLength(10)]
    [XmlText()]
public string value { get; set; }
}
public class Kontaktinformasjongrp9311{
[Range(1,Int32.MaxValue)]
    [XmlAttribute("gruppeid")]
    [BindNever]
public decimal gruppeid {get; set;} = 9311;
    [XmlElement("MeldingFodselsnummer-datadef-34734")]
    [JsonProperty("MeldingFodselsnummer-datadef-34734")]
    [JsonPropertyName("MeldingFodselsnummer-datadef-34734")]
public MeldingFodselsnummerdatadef34734 MeldingFodselsnummerdatadef34734 { get; set; }
    [XmlElement("MelderFornavn-datadef-34736")]
    [JsonProperty("MelderFornavn-datadef-34736")]
    [JsonPropertyName("MelderFornavn-datadef-34736")]
public MelderFornavndatadef34736 MelderFornavndatadef34736 { get; set; }
    [XmlElement("MelderMellomnavn-datadef-34737")]
    [JsonProperty("MelderMellomnavn-datadef-34737")]
    [JsonPropertyName("MelderMellomnavn-datadef-34737")]
public MelderMellomnavndatadef34737 MelderMellomnavndatadef34737 { get; set; }
    [XmlElement("MelderEtternavn-datadef-34735")]
    [JsonProperty("MelderEtternavn-datadef-34735")]
    [JsonPropertyName("MelderEtternavn-datadef-34735")]
public MelderEtternavndatadef34735 MelderEtternavndatadef34735 { get; set; }
    [XmlElement("MelderFultnavn")]
    [JsonProperty("MelderFultnavn")]
    [JsonPropertyName("MelderFultnavn")]
public MelderFultnavn MelderFultnavn { get; set; }
    [XmlElement("MelderEpost-datadef-34739")]
    [JsonProperty("MelderEpost-datadef-34739")]
    [JsonPropertyName("MelderEpost-datadef-34739")]
public MelderEpostdatadef34739 MelderEpostdatadef34739 { get; set; }
    [XmlElement("MelderMobiltelefonnummer-datadef-34740")]
    [JsonProperty("MelderMobiltelefonnummer-datadef-34740")]
    [JsonPropertyName("MelderMobiltelefonnummer-datadef-34740")]
public MelderMobiltelefonnummerdatadef34740 MelderMobiltelefonnummerdatadef34740 { get; set; }
    [XmlElement("MelderArkivDato-datadef-34741")]
    [JsonProperty("MelderArkivDato-datadef-34741")]
    [JsonPropertyName("MelderArkivDato-datadef-34741")]
public MelderArkivDatodatadef34741 MelderArkivDatodatadef34741 { get; set; }
    [XmlElement("MelderArkivTidspunkt-datadef-34742")]
    [JsonProperty("MelderArkivTidspunkt-datadef-34742")]
    [JsonPropertyName("MelderArkivTidspunkt-datadef-34742")]
public MelderArkivTidspunktdatadef34742 MelderArkivTidspunktdatadef34742 { get; set; }
    [XmlElement("MelderReferanseAltinn-datadef-34743")]
    [JsonProperty("MelderReferanseAltinn-datadef-34743")]
    [JsonPropertyName("MelderReferanseAltinn-datadef-34743")]
public MelderReferanseAltinndatadef34743 MelderReferanseAltinndatadef34743 { get; set; }
    [XmlElement("MelderMalform-datadef-34882")]
    [JsonProperty("MelderMalform-datadef-34882")]
    [JsonPropertyName("MelderMalform-datadef-34882")]
public MelderMalformdatadef34882 MelderMalformdatadef34882 { get; set; }
}
public class MeldingFodselsnummerdatadef34734{
[Range(1,Int32.MaxValue)]
    [XmlAttribute("orid")]
    [BindNever]
public decimal orid {get; set;} = 34734;
    [XmlText()]
public string value { get; set; }
}
public class MelderFornavndatadef34736{
[Range(1,Int32.MaxValue)]
    [XmlAttribute("orid")]
    [BindNever]
public decimal orid {get; set;} = 34736;
[MinLength(1)]
[MaxLength(60)]
    [XmlText()]
public string value { get; set; }
}
public class MelderMellomnavndatadef34737{
[Range(1,Int32.MaxValue)]
    [XmlAttribute("orid")]
    [BindNever]
public decimal orid {get; set;} = 34737;
[MinLength(1)]
[MaxLength(60)]
    [XmlText()]
public string value { get; set; }
}
public class MelderEtternavndatadef34735{
[Range(1,Int32.MaxValue)]
    [XmlAttribute("orid")]
    [BindNever]
public decimal orid {get; set;} = 34735;
[MinLength(1)]
[MaxLength(60)]
    [XmlText()]
public string value { get; set; }
}
public class MelderFultnavn{
[Range(1,Int32.MaxValue)]
    [XmlAttribute("orid")]
    [BindNever]
public decimal orid {get; set;} = 34735;
[MinLength(1)]
[MaxLength(60)]
    [XmlText()]
public string value { get; set; }
}
public class MelderEpostdatadef34739{
[Range(1,Int32.MaxValue)]
    [XmlAttribute("orid")]
    [BindNever]
public decimal orid {get; set;} = 34739;
[MinLength(1)]
[MaxLength(50)]
    [XmlText()]
public string value { get; set; }
}
public class MelderMobiltelefonnummerdatadef34740{
[Range(1,Int32.MaxValue)]
    [XmlAttribute("orid")]
    [BindNever]
public decimal orid {get; set;} = 34740;
[MinLength(1)]
[MaxLength(15)]
    [XmlText()]
public string value { get; set; }
}
public class MelderArkivDatodatadef34741{
[Range(1,Int32.MaxValue)]
    [XmlAttribute("orid")]
    [BindNever]
public decimal orid {get; set;} = 34741;
    [XmlText()]
public DateTime value { get; set; }
}
public class MelderArkivTidspunktdatadef34742{
[Range(1,Int32.MaxValue)]
    [XmlAttribute("orid")]
    [BindNever]
public decimal orid {get; set;} = 34742;
[RegularExpression(@"^([0,1][0-9]|[2][0-3]):[0-5][0-9]:[0-5][0-9](Z|(\+|-)([0,1][0-9]|[2][0-3]):[0-5][0-9])?$")]
    [XmlText()]
public string value { get; set; }
}
public class MelderReferanseAltinndatadef34743{
[Range(1,Int32.MaxValue)]
    [XmlAttribute("orid")]
    [BindNever]
public decimal orid {get; set;} = 34743;
[MinLength(1)]
[MaxLength(10)]
    [XmlText()]
public string value { get; set; }
}
public class MelderMalformdatadef34882{
[Range(1,Int32.MaxValue)]
    [XmlAttribute("orid")]
    [BindNever]
public decimal orid {get; set;} = 34882;
[MinLength(1)]
[MaxLength(10)]
    [XmlText()]
public string value { get; set; }
}
public class SamtykkeTilElektroniskKommunikasjongrp9312{
[Range(1,Int32.MaxValue)]
    [XmlAttribute("gruppeid")]
    [BindNever]
public decimal gruppeid {get; set;} = 9312;
    [XmlElement("AvgiverSkattSamtykke-datadef-34755")]
    [JsonProperty("AvgiverSkattSamtykke-datadef-34755")]
    [JsonPropertyName("AvgiverSkattSamtykke-datadef-34755")]
public AvgiverSkattSamtykkedatadef34755 AvgiverSkattSamtykkedatadef34755 { get; set; }
    [XmlElement("AvgiverFolkeregisterSamtykke-datadef-34756")]
    [JsonProperty("AvgiverFolkeregisterSamtykke-datadef-34756")]
    [JsonPropertyName("AvgiverFolkeregisterSamtykke-datadef-34756")]
public AvgiverFolkeregisterSamtykkedatadef34756 AvgiverFolkeregisterSamtykkedatadef34756 { get; set; }
}
public class AvgiverSkattSamtykkedatadef34755{
[Range(1,Int32.MaxValue)]
    [XmlAttribute("orid")]
    [BindNever]
public decimal orid {get; set;} = 34755;
[RegularExpression(@"(J|N|D)")]
    [XmlText()]
public string value { get; set; }
}
public class AvgiverFolkeregisterSamtykkedatadef34756{
[Range(1,Int32.MaxValue)]
    [XmlAttribute("orid")]
    [BindNever]
public decimal orid {get; set;} = 34756;
[RegularExpression(@"(J|N|D)")]
    [XmlText()]
public string value { get; set; }
}
public class NyttNavngrp9313{
[Range(1,Int32.MaxValue)]
    [XmlAttribute("gruppeid")]
    [BindNever]
public decimal gruppeid {get; set;} = 9313;
    [XmlElement("NyttNavn-grp-9314")]
    [JsonProperty("NyttNavn-grp-9314")]
    [JsonPropertyName("NyttNavn-grp-9314")]
public NyttNavngrp9314 NyttNavngrp9314 { get; set; }
}
public class NyttNavngrp9314{
[Range(1,Int32.MaxValue)]
    [XmlAttribute("gruppeid")]
    [BindNever]
public decimal gruppeid {get; set;} = 9314;
    [XmlElement("PersonEtternavnNytt-datadef-34757")]
    [JsonProperty("PersonEtternavnNytt-datadef-34757")]
    [JsonPropertyName("PersonEtternavnNytt-datadef-34757")]
public PersonEtternavnNyttdatadef34757 PersonEtternavnNyttdatadef34757 { get; set; }
    [XmlElement("PersonFornavnNytt-datadef-34758")]
    [JsonProperty("PersonFornavnNytt-datadef-34758")]
    [JsonPropertyName("PersonFornavnNytt-datadef-34758")]
public PersonFornavnNyttdatadef34758 PersonFornavnNyttdatadef34758 { get; set; }
    [XmlElement("PersonMellomnavnNytt-datadef-34759")]
    [JsonProperty("PersonMellomnavnNytt-datadef-34759")]
    [JsonPropertyName("PersonMellomnavnNytt-datadef-34759")]
public PersonMellomnavnNyttdatadef34759 PersonMellomnavnNyttdatadef34759 { get; set; }
    [XmlElement("PersonBekrefterNyttNavn")]
    [JsonProperty("PersonBekrefterNyttNavn")]
    [JsonPropertyName("PersonBekrefterNyttNavn")]
public PersonBekrefterNyttNavn PersonBekrefterNyttNavn { get; set; }
}
public class PersonEtternavnNyttdatadef34757{
[Range(1,Int32.MaxValue)]
    [XmlAttribute("orid")]
    [BindNever]
public decimal orid {get; set;} = 34757;
[MinLength(1)]
[MaxLength(50)]
    [XmlText()]
public string value { get; set; }
}
public class PersonFornavnNyttdatadef34758{
[Range(1,Int32.MaxValue)]
    [XmlAttribute("orid")]
    [BindNever]
public decimal orid {get; set;} = 34758;
[MinLength(1)]
[MaxLength(50)]
    [XmlText()]
public string value { get; set; }
}
public class PersonMellomnavnNyttdatadef34759{
[Range(1,Int32.MaxValue)]
    [XmlAttribute("orid")]
    [BindNever]
public decimal orid {get; set;} = 34759;
[MinLength(1)]
[MaxLength(50)]
    [XmlText()]
public string value { get; set; }
}
public class PersonBekrefterNyttNavn{
[Range(1,Int32.MaxValue)]
    [XmlAttribute("orid")]
    [BindNever]
public decimal orid {get; set;} = 34760;
[MinLength(1)]
[MaxLength(50)]
    [XmlText()]
public string value { get; set; }
}
public class Tilknytninggrp9315{
[Range(1,Int32.MaxValue)]
    [XmlAttribute("gruppeid")]
    [BindNever]
public decimal gruppeid {get; set;} = 9315;
    [XmlElement("TilknytningTilNavnet-grp-9316")]
    [JsonProperty("TilknytningTilNavnet-grp-9316")]
    [JsonPropertyName("TilknytningTilNavnet-grp-9316")]
public TilknytningTilNavnetgrp9316 TilknytningTilNavnetgrp9316 { get; set; }
}
public class TilknytningTilNavnetgrp9316{
[Range(1,Int32.MaxValue)]
    [XmlAttribute("gruppeid")]
    [BindNever]
public decimal gruppeid {get; set;} = 9316;
    [XmlElement("TilknytningEtternavn1-grp-9350")]
    [JsonProperty("TilknytningEtternavn1-grp-9350")]
    [JsonPropertyName("TilknytningEtternavn1-grp-9350")]
public TilknytningEtternavn1grp9350 TilknytningEtternavn1grp9350 { get; set; }
    [XmlElement("TilknytningEtternavn2-grp-9351")]
    [JsonProperty("TilknytningEtternavn2-grp-9351")]
    [JsonPropertyName("TilknytningEtternavn2-grp-9351")]
public TilknytningEtternavn2grp9351 TilknytningEtternavn2grp9351 { get; set; }
    [XmlElement("TilknytningMellomnavn1-grp-9352")]
    [JsonProperty("TilknytningMellomnavn1-grp-9352")]
    [JsonPropertyName("TilknytningMellomnavn1-grp-9352")]
public TilknytningMellomnavn1grp9352 TilknytningMellomnavn1grp9352 { get; set; }
    [XmlElement("TilknytningMellomnavn2-grp-9353")]
    [JsonProperty("TilknytningMellomnavn2-grp-9353")]
    [JsonPropertyName("TilknytningMellomnavn2-grp-9353")]
public TilknytningMellomnavn2grp9353 TilknytningMellomnavn2grp9353 { get; set; }
    [XmlElement("TilknytningMellomnavn3-grp-9354")]
    [JsonProperty("TilknytningMellomnavn3-grp-9354")]
    [JsonPropertyName("TilknytningMellomnavn3-grp-9354")]
public TilknytningMellomnavn3grp9354 TilknytningMellomnavn3grp9354 { get; set; }
    [XmlElement("TilknytningMellomnavnEkstra-grp-9355")]
    [JsonProperty("TilknytningMellomnavnEkstra-grp-9355")]
    [JsonPropertyName("TilknytningMellomnavnEkstra-grp-9355")]
public TilknytningMellomnavnEkstragrp9355 TilknytningMellomnavnEkstragrp9355 { get; set; }
}
public class TilknytningEtternavn1grp9350{
[Range(1,Int32.MaxValue)]
    [XmlAttribute("gruppeid")]
    [BindNever]
public decimal gruppeid {get; set;} = 9350;
    [XmlElement("PersonEtternavnForste-datadef-34896")]
    [JsonProperty("PersonEtternavnForste-datadef-34896")]
    [JsonPropertyName("PersonEtternavnForste-datadef-34896")]
public PersonEtternavnForstedatadef34896 PersonEtternavnForstedatadef34896 { get; set; }
    [XmlElement("PersonEtternavnForsteTilknytningstype-datadef-34897")]
    [JsonProperty("PersonEtternavnForsteTilknytningstype-datadef-34897")]
    [JsonPropertyName("PersonEtternavnForsteTilknytningstype-datadef-34897")]
public PersonEtternavnForsteTilknytningstypedatadef34897 PersonEtternavnForsteTilknytningstypedatadef34897 { get; set; }
    [XmlElement("PersonEtternavnForsteTilknytningBeskrivelse-datadef-34898")]
    [JsonProperty("PersonEtternavnForsteTilknytningBeskrivelse-datadef-34898")]
    [JsonPropertyName("PersonEtternavnForsteTilknytningBeskrivelse-datadef-34898")]
public PersonEtternavnForsteTilknytningBeskrivelsedatadef34898 PersonEtternavnForsteTilknytningBeskrivelsedatadef34898 { get; set; }
    [XmlElement("PersonEtternavnForsteTilknyttetPersonsFodselsnummer-datadef-34899")]
    [JsonProperty("PersonEtternavnForsteTilknyttetPersonsFodselsnummer-datadef-34899")]
    [JsonPropertyName("PersonEtternavnForsteTilknyttetPersonsFodselsnummer-datadef-34899")]
public PersonEtternavnForsteTilknyttetPersonsFodselsnummerdatadef34899 PersonEtternavnForsteTilknyttetPersonsFodselsnummerdatadef34899 { get; set; }
    [XmlElement("PersonEtternavnForsteTilknyttetPersonsEtternavn-datadef-34900")]
    [JsonProperty("PersonEtternavnForsteTilknyttetPersonsEtternavn-datadef-34900")]
    [JsonPropertyName("PersonEtternavnForsteTilknyttetPersonsEtternavn-datadef-34900")]
public PersonEtternavnForsteTilknyttetPersonsEtternavndatadef34900 PersonEtternavnForsteTilknyttetPersonsEtternavndatadef34900 { get; set; }
    [XmlElement("PersonEtternavnForsteTilknyttetGardNavn-datadef-34901")]
    [JsonProperty("PersonEtternavnForsteTilknyttetGardNavn-datadef-34901")]
    [JsonPropertyName("PersonEtternavnForsteTilknyttetGardNavn-datadef-34901")]
public PersonEtternavnForsteTilknyttetGardNavndatadef34901 PersonEtternavnForsteTilknyttetGardNavndatadef34901 { get; set; }
    [XmlElement("PersonEtternavnForsteTilknyttetGardKommunenummer-datadef-34902")]
    [JsonProperty("PersonEtternavnForsteTilknyttetGardKommunenummer-datadef-34902")]
    [JsonPropertyName("PersonEtternavnForsteTilknyttetGardKommunenummer-datadef-34902")]
public PersonEtternavnForsteTilknyttetGardKommunenummerdatadef34902 PersonEtternavnForsteTilknyttetGardKommunenummerdatadef34902 { get; set; }
    [XmlElement("PersonEtternavnForsteTilknyttetGardGardsnummer-datadef-34903")]
    [JsonProperty("PersonEtternavnForsteTilknyttetGardGardsnummer-datadef-34903")]
    [JsonPropertyName("PersonEtternavnForsteTilknyttetGardGardsnummer-datadef-34903")]
public PersonEtternavnForsteTilknyttetGardGardsnummerdatadef34903 PersonEtternavnForsteTilknyttetGardGardsnummerdatadef34903 { get; set; }
    [XmlElement("PersonEtternavnForsteTilknyttetGardBruksnummer-datadef-34904")]
    [JsonProperty("PersonEtternavnForsteTilknyttetGardBruksnummer-datadef-34904")]
    [JsonPropertyName("PersonEtternavnForsteTilknyttetGardBruksnummer-datadef-34904")]
public PersonEtternavnForsteTilknyttetGardBruksnummerdatadef34904 PersonEtternavnForsteTilknyttetGardBruksnummerdatadef34904 { get; set; }
    [XmlElement("PersonEtternavnForsteTilknyttetGardFesteavgift-datadef-34905")]
    [JsonProperty("PersonEtternavnForsteTilknyttetGardFesteavgift-datadef-34905")]
    [JsonPropertyName("PersonEtternavnForsteTilknyttetGardFesteavgift-datadef-34905")]
public PersonEtternavnForsteTilknyttetGardFesteavgiftdatadef34905 PersonEtternavnForsteTilknyttetGardFesteavgiftdatadef34905 { get; set; }
}
public class PersonEtternavnForstedatadef34896{
[Range(1,Int32.MaxValue)]
    [XmlAttribute("orid")]
    [BindNever]
public decimal orid {get; set;} = 34896;
[MinLength(1)]
[MaxLength(50)]
    [XmlText()]
public string value { get; set; }
}
public class PersonEtternavnForsteTilknytningstypedatadef34897{
[Range(1,Int32.MaxValue)]
    [XmlAttribute("orid")]
    [BindNever]
public decimal orid {get; set;} = 34897;
[MinLength(1)]
[MaxLength(2)]
    [XmlText()]
public string value { get; set; }
}
public class PersonEtternavnForsteTilknytningBeskrivelsedatadef34898{
[Range(1,Int32.MaxValue)]
    [XmlAttribute("orid")]
    [BindNever]
public decimal orid {get; set;} = 34898;
[MinLength(1)]
[MaxLength(500)]
    [XmlText()]
public string value { get; set; }
}
public class PersonEtternavnForsteTilknyttetPersonsFodselsnummerdatadef34899{
[Range(1,Int32.MaxValue)]
    [XmlAttribute("orid")]
    [BindNever]
public decimal orid {get; set;} = 34899;
    [XmlText()]
public string value { get; set; }
}
public class PersonEtternavnForsteTilknyttetPersonsEtternavndatadef34900{
[Range(1,Int32.MaxValue)]
    [XmlAttribute("orid")]
    [BindNever]
public decimal orid {get; set;} = 34900;
[MinLength(1)]
[MaxLength(50)]
    [XmlText()]
public string value { get; set; }
}
public class PersonEtternavnForsteTilknyttetGardNavndatadef34901{
[Range(1,Int32.MaxValue)]
    [XmlAttribute("orid")]
    [BindNever]
public decimal orid {get; set;} = 34901;
[MinLength(1)]
[MaxLength(50)]
    [XmlText()]
public string value { get; set; }
}
public class PersonEtternavnForsteTilknyttetGardKommunenummerdatadef34902{
[Range(1,Int32.MaxValue)]
    [XmlAttribute("orid")]
    [BindNever]
public decimal orid {get; set;} = 34902;
[RegularExpression(@"[0-9]{4}")]
    [XmlText()]
public string value { get; set; }
}
public class PersonEtternavnForsteTilknyttetGardGardsnummerdatadef34903{
[Range(1,Int32.MaxValue)]
    [XmlAttribute("orid")]
    [BindNever]
public decimal orid {get; set;} = 34903;
[MinLength(1)]
[MaxLength(5)]
    [XmlText()]
public string value { get; set; }
}
public class PersonEtternavnForsteTilknyttetGardBruksnummerdatadef34904{
[Range(1,Int32.MaxValue)]
    [XmlAttribute("orid")]
    [BindNever]
public decimal orid {get; set;} = 34904;
[MinLength(1)]
[MaxLength(4)]
    [XmlText()]
public string value { get; set; }
}
public class PersonEtternavnForsteTilknyttetGardFesteavgiftdatadef34905{
[Range(1,Int32.MaxValue)]
    [XmlAttribute("orid")]
    [BindNever]
public decimal orid {get; set;} = 34905;
[MinLength(1)]
[MaxLength(4)]
    [XmlText()]
public string value { get; set; }
}
public class TilknytningEtternavn2grp9351{
[Range(1,Int32.MaxValue)]
    [XmlAttribute("gruppeid")]
    [BindNever]
public decimal gruppeid {get; set;} = 9351;
    [XmlElement("PersonEtternavnAndre-datadef-34906")]
    [JsonProperty("PersonEtternavnAndre-datadef-34906")]
    [JsonPropertyName("PersonEtternavnAndre-datadef-34906")]
public PersonEtternavnAndredatadef34906 PersonEtternavnAndredatadef34906 { get; set; }
    [XmlElement("PersonEtternavnAndreTilknytningstype-datadef-34907")]
    [JsonProperty("PersonEtternavnAndreTilknytningstype-datadef-34907")]
    [JsonPropertyName("PersonEtternavnAndreTilknytningstype-datadef-34907")]
public PersonEtternavnAndreTilknytningstypedatadef34907 PersonEtternavnAndreTilknytningstypedatadef34907 { get; set; }
    [XmlElement("PersonEtternavnAndreTilknytningBeskrivelse-datadef-34908")]
    [JsonProperty("PersonEtternavnAndreTilknytningBeskrivelse-datadef-34908")]
    [JsonPropertyName("PersonEtternavnAndreTilknytningBeskrivelse-datadef-34908")]
public PersonEtternavnAndreTilknytningBeskrivelsedatadef34908 PersonEtternavnAndreTilknytningBeskrivelsedatadef34908 { get; set; }
    [XmlElement("PersonEtternavnAndreTilknyttetPersonsFodselsnummer-datadef-34909")]
    [JsonProperty("PersonEtternavnAndreTilknyttetPersonsFodselsnummer-datadef-34909")]
    [JsonPropertyName("PersonEtternavnAndreTilknyttetPersonsFodselsnummer-datadef-34909")]
public PersonEtternavnAndreTilknyttetPersonsFodselsnummerdatadef34909 PersonEtternavnAndreTilknyttetPersonsFodselsnummerdatadef34909 { get; set; }
    [XmlElement("PersonEtternavnAndreTilknyttetPersonsEtternavn-datadef-34910")]
    [JsonProperty("PersonEtternavnAndreTilknyttetPersonsEtternavn-datadef-34910")]
    [JsonPropertyName("PersonEtternavnAndreTilknyttetPersonsEtternavn-datadef-34910")]
public PersonEtternavnAndreTilknyttetPersonsEtternavndatadef34910 PersonEtternavnAndreTilknyttetPersonsEtternavndatadef34910 { get; set; }
    [XmlElement("PersonEtternavnAndreTilknyttetGardNavn-datadef-34911")]
    [JsonProperty("PersonEtternavnAndreTilknyttetGardNavn-datadef-34911")]
    [JsonPropertyName("PersonEtternavnAndreTilknyttetGardNavn-datadef-34911")]
public PersonEtternavnAndreTilknyttetGardNavndatadef34911 PersonEtternavnAndreTilknyttetGardNavndatadef34911 { get; set; }
    [XmlElement("PersonEtternavnAndreTilknyttetGardKommunenummer-datadef-34912")]
    [JsonProperty("PersonEtternavnAndreTilknyttetGardKommunenummer-datadef-34912")]
    [JsonPropertyName("PersonEtternavnAndreTilknyttetGardKommunenummer-datadef-34912")]
public PersonEtternavnAndreTilknyttetGardKommunenummerdatadef34912 PersonEtternavnAndreTilknyttetGardKommunenummerdatadef34912 { get; set; }
    [XmlElement("PersonEtternavnAndreTilknyttetGardGardsnummer-datadef-34913")]
    [JsonProperty("PersonEtternavnAndreTilknyttetGardGardsnummer-datadef-34913")]
    [JsonPropertyName("PersonEtternavnAndreTilknyttetGardGardsnummer-datadef-34913")]
public PersonEtternavnAndreTilknyttetGardGardsnummerdatadef34913 PersonEtternavnAndreTilknyttetGardGardsnummerdatadef34913 { get; set; }
    [XmlElement("PersonEtternavnAndreTilknyttetGardBruksnummer-datadef-34914")]
    [JsonProperty("PersonEtternavnAndreTilknyttetGardBruksnummer-datadef-34914")]
    [JsonPropertyName("PersonEtternavnAndreTilknyttetGardBruksnummer-datadef-34914")]
public PersonEtternavnAndreTilknyttetGardBruksnummerdatadef34914 PersonEtternavnAndreTilknyttetGardBruksnummerdatadef34914 { get; set; }
    [XmlElement("PersonEtternavnAndreTilknyttetGardFesteavgift-datadef-34915")]
    [JsonProperty("PersonEtternavnAndreTilknyttetGardFesteavgift-datadef-34915")]
    [JsonPropertyName("PersonEtternavnAndreTilknyttetGardFesteavgift-datadef-34915")]
public PersonEtternavnAndreTilknyttetGardFesteavgiftdatadef34915 PersonEtternavnAndreTilknyttetGardFesteavgiftdatadef34915 { get; set; }
}
public class PersonEtternavnAndredatadef34906{
[Range(1,Int32.MaxValue)]
    [XmlAttribute("orid")]
    [BindNever]
public decimal orid {get; set;} = 34906;
[MinLength(1)]
[MaxLength(50)]
    [XmlText()]
public string value { get; set; }
}
public class PersonEtternavnAndreTilknytningstypedatadef34907{
[Range(1,Int32.MaxValue)]
    [XmlAttribute("orid")]
    [BindNever]
public decimal orid {get; set;} = 34907;
[MinLength(1)]
[MaxLength(2)]
    [XmlText()]
public string value { get; set; }
}
public class PersonEtternavnAndreTilknytningBeskrivelsedatadef34908{
[Range(1,Int32.MaxValue)]
    [XmlAttribute("orid")]
    [BindNever]
public decimal orid {get; set;} = 34908;
[MinLength(1)]
[MaxLength(500)]
    [XmlText()]
public string value { get; set; }
}
public class PersonEtternavnAndreTilknyttetPersonsFodselsnummerdatadef34909{
[Range(1,Int32.MaxValue)]
    [XmlAttribute("orid")]
    [BindNever]
public decimal orid {get; set;} = 34909;
    [XmlText()]
public string value { get; set; }
}
public class PersonEtternavnAndreTilknyttetPersonsEtternavndatadef34910{
[Range(1,Int32.MaxValue)]
    [XmlAttribute("orid")]
    [BindNever]
public decimal orid {get; set;} = 34910;
[MinLength(1)]
[MaxLength(50)]
    [XmlText()]
public string value { get; set; }
}
public class PersonEtternavnAndreTilknyttetGardNavndatadef34911{
[Range(1,Int32.MaxValue)]
    [XmlAttribute("orid")]
    [BindNever]
public decimal orid {get; set;} = 34911;
[MinLength(1)]
[MaxLength(50)]
    [XmlText()]
public string value { get; set; }
}
public class PersonEtternavnAndreTilknyttetGardKommunenummerdatadef34912{
[Range(1,Int32.MaxValue)]
    [XmlAttribute("orid")]
    [BindNever]
public decimal orid {get; set;} = 34912;
[RegularExpression(@"[0-9]{4}")]
    [XmlText()]
public string value { get; set; }
}
public class PersonEtternavnAndreTilknyttetGardGardsnummerdatadef34913{
[Range(1,Int32.MaxValue)]
    [XmlAttribute("orid")]
    [BindNever]
public decimal orid {get; set;} = 34913;
[MinLength(1)]
[MaxLength(5)]
    [XmlText()]
public string value { get; set; }
}
public class PersonEtternavnAndreTilknyttetGardBruksnummerdatadef34914{
[Range(1,Int32.MaxValue)]
    [XmlAttribute("orid")]
    [BindNever]
public decimal orid {get; set;} = 34914;
[MinLength(1)]
[MaxLength(4)]
    [XmlText()]
public string value { get; set; }
}
public class PersonEtternavnAndreTilknyttetGardFesteavgiftdatadef34915{
[Range(1,Int32.MaxValue)]
    [XmlAttribute("orid")]
    [BindNever]
public decimal orid {get; set;} = 34915;
[MinLength(1)]
[MaxLength(4)]
    [XmlText()]
public string value { get; set; }
}
public class TilknytningMellomnavn1grp9352{
[Range(1,Int32.MaxValue)]
    [XmlAttribute("gruppeid")]
    [BindNever]
public decimal gruppeid {get; set;} = 9352;
    [XmlElement("PersonMellomnavnForste-datadef-34916")]
    [JsonProperty("PersonMellomnavnForste-datadef-34916")]
    [JsonPropertyName("PersonMellomnavnForste-datadef-34916")]
public PersonMellomnavnForstedatadef34916 PersonMellomnavnForstedatadef34916 { get; set; }
    [XmlElement("PersonMellomnavnForsteTilknytningstype-datadef-34917")]
    [JsonProperty("PersonMellomnavnForsteTilknytningstype-datadef-34917")]
    [JsonPropertyName("PersonMellomnavnForsteTilknytningstype-datadef-34917")]
public PersonMellomnavnForsteTilknytningstypedatadef34917 PersonMellomnavnForsteTilknytningstypedatadef34917 { get; set; }
    [XmlElement("PersonMellomnavnForsteTilknytningBeskrivelse-datadef-34918")]
    [JsonProperty("PersonMellomnavnForsteTilknytningBeskrivelse-datadef-34918")]
    [JsonPropertyName("PersonMellomnavnForsteTilknytningBeskrivelse-datadef-34918")]
public PersonMellomnavnForsteTilknytningBeskrivelsedatadef34918 PersonMellomnavnForsteTilknytningBeskrivelsedatadef34918 { get; set; }
    [XmlElement("PersonMellomnavnForsteTilknyttetPersonsFodselsnummer-datadef-34919")]
    [JsonProperty("PersonMellomnavnForsteTilknyttetPersonsFodselsnummer-datadef-34919")]
    [JsonPropertyName("PersonMellomnavnForsteTilknyttetPersonsFodselsnummer-datadef-34919")]
public PersonMellomnavnForsteTilknyttetPersonsFodselsnummerdatadef34919 PersonMellomnavnForsteTilknyttetPersonsFodselsnummerdatadef34919 { get; set; }
    [XmlElement("PersonMellomnavnForsteTilknyttetPersonsEtternavn-datadef-34920")]
    [JsonProperty("PersonMellomnavnForsteTilknyttetPersonsEtternavn-datadef-34920")]
    [JsonPropertyName("PersonMellomnavnForsteTilknyttetPersonsEtternavn-datadef-34920")]
public PersonMellomnavnForsteTilknyttetPersonsEtternavndatadef34920 PersonMellomnavnForsteTilknyttetPersonsEtternavndatadef34920 { get; set; }
    [XmlElement("PersonMellomnavnForsteTilknyttetGardNavn-datadef-34921")]
    [JsonProperty("PersonMellomnavnForsteTilknyttetGardNavn-datadef-34921")]
    [JsonPropertyName("PersonMellomnavnForsteTilknyttetGardNavn-datadef-34921")]
public PersonMellomnavnForsteTilknyttetGardNavndatadef34921 PersonMellomnavnForsteTilknyttetGardNavndatadef34921 { get; set; }
    [XmlElement("PersonMellomnavnForsteTilknyttetGardKommunenummer-datadef-34922")]
    [JsonProperty("PersonMellomnavnForsteTilknyttetGardKommunenummer-datadef-34922")]
    [JsonPropertyName("PersonMellomnavnForsteTilknyttetGardKommunenummer-datadef-34922")]
public PersonMellomnavnForsteTilknyttetGardKommunenummerdatadef34922 PersonMellomnavnForsteTilknyttetGardKommunenummerdatadef34922 { get; set; }
    [XmlElement("PersonMellomnavnForsteTilknyttetGardGardsnummer-datadef-34923")]
    [JsonProperty("PersonMellomnavnForsteTilknyttetGardGardsnummer-datadef-34923")]
    [JsonPropertyName("PersonMellomnavnForsteTilknyttetGardGardsnummer-datadef-34923")]
public PersonMellomnavnForsteTilknyttetGardGardsnummerdatadef34923 PersonMellomnavnForsteTilknyttetGardGardsnummerdatadef34923 { get; set; }
    [XmlElement("PersonMellomnavnForsteTilknyttetGardBruksnummer-datadef-34924")]
    [JsonProperty("PersonMellomnavnForsteTilknyttetGardBruksnummer-datadef-34924")]
    [JsonPropertyName("PersonMellomnavnForsteTilknyttetGardBruksnummer-datadef-34924")]
public PersonMellomnavnForsteTilknyttetGardBruksnummerdatadef34924 PersonMellomnavnForsteTilknyttetGardBruksnummerdatadef34924 { get; set; }
    [XmlElement("PersonMellomnavnForsteTilknyttetGardFestenummer-datadef-34925")]
    [JsonProperty("PersonMellomnavnForsteTilknyttetGardFestenummer-datadef-34925")]
    [JsonPropertyName("PersonMellomnavnForsteTilknyttetGardFestenummer-datadef-34925")]
public PersonMellomnavnForsteTilknyttetGardFestenummerdatadef34925 PersonMellomnavnForsteTilknyttetGardFestenummerdatadef34925 { get; set; }
}
public class PersonMellomnavnForstedatadef34916{
[Range(1,Int32.MaxValue)]
    [XmlAttribute("orid")]
    [BindNever]
public decimal orid {get; set;} = 34916;
[MinLength(1)]
[MaxLength(50)]
    [XmlText()]
public string value { get; set; }
}
public class PersonMellomnavnForsteTilknytningstypedatadef34917{
[Range(1,Int32.MaxValue)]
    [XmlAttribute("orid")]
    [BindNever]
public decimal orid {get; set;} = 34917;
[MinLength(1)]
[MaxLength(2)]
    [XmlText()]
public string value { get; set; }
}
public class PersonMellomnavnForsteTilknytningBeskrivelsedatadef34918{
[Range(1,Int32.MaxValue)]
    [XmlAttribute("orid")]
    [BindNever]
public decimal orid {get; set;} = 34918;
[MinLength(1)]
[MaxLength(500)]
    [XmlText()]
public string value { get; set; }
}
public class PersonMellomnavnForsteTilknyttetPersonsFodselsnummerdatadef34919{
[Range(1,Int32.MaxValue)]
    [XmlAttribute("orid")]
    [BindNever]
public decimal orid {get; set;} = 34919;
    [XmlText()]
public string value { get; set; }
}
public class PersonMellomnavnForsteTilknyttetPersonsEtternavndatadef34920{
[Range(1,Int32.MaxValue)]
    [XmlAttribute("orid")]
    [BindNever]
public decimal orid {get; set;} = 34920;
[MinLength(1)]
[MaxLength(50)]
    [XmlText()]
public string value { get; set; }
}
public class PersonMellomnavnForsteTilknyttetGardNavndatadef34921{
[Range(1,Int32.MaxValue)]
    [XmlAttribute("orid")]
    [BindNever]
public decimal orid {get; set;} = 34921;
[MinLength(1)]
[MaxLength(50)]
    [XmlText()]
public string value { get; set; }
}
public class PersonMellomnavnForsteTilknyttetGardKommunenummerdatadef34922{
[Range(1,Int32.MaxValue)]
    [XmlAttribute("orid")]
    [BindNever]
public decimal orid {get; set;} = 34922;
[RegularExpression(@"[0-9]{4}")]
    [XmlText()]
public string value { get; set; }
}
public class PersonMellomnavnForsteTilknyttetGardGardsnummerdatadef34923{
[Range(1,Int32.MaxValue)]
    [XmlAttribute("orid")]
    [BindNever]
public decimal orid {get; set;} = 34923;
[MinLength(1)]
[MaxLength(5)]
    [XmlText()]
public string value { get; set; }
}
public class PersonMellomnavnForsteTilknyttetGardBruksnummerdatadef34924{
[Range(1,Int32.MaxValue)]
    [XmlAttribute("orid")]
    [BindNever]
public decimal orid {get; set;} = 34924;
[MinLength(1)]
[MaxLength(4)]
    [XmlText()]
public string value { get; set; }
}
public class PersonMellomnavnForsteTilknyttetGardFestenummerdatadef34925{
[Range(1,Int32.MaxValue)]
    [XmlAttribute("orid")]
    [BindNever]
public decimal orid {get; set;} = 34925;
[MinLength(1)]
[MaxLength(4)]
    [XmlText()]
public string value { get; set; }
}
public class TilknytningMellomnavn2grp9353{
[Range(1,Int32.MaxValue)]
    [XmlAttribute("gruppeid")]
    [BindNever]
public decimal gruppeid {get; set;} = 9353;
    [XmlElement("PersonMellomnavnAndre-datadef-34926")]
    [JsonProperty("PersonMellomnavnAndre-datadef-34926")]
    [JsonPropertyName("PersonMellomnavnAndre-datadef-34926")]
public PersonMellomnavnAndredatadef34926 PersonMellomnavnAndredatadef34926 { get; set; }
    [XmlElement("PersonMellomnavnAndreTilknytningstype-datadef-34927")]
    [JsonProperty("PersonMellomnavnAndreTilknytningstype-datadef-34927")]
    [JsonPropertyName("PersonMellomnavnAndreTilknytningstype-datadef-34927")]
public PersonMellomnavnAndreTilknytningstypedatadef34927 PersonMellomnavnAndreTilknytningstypedatadef34927 { get; set; }
    [XmlElement("PersonMellomnavnAndreTilknytningBeskrivelse-datadef-34928")]
    [JsonProperty("PersonMellomnavnAndreTilknytningBeskrivelse-datadef-34928")]
    [JsonPropertyName("PersonMellomnavnAndreTilknytningBeskrivelse-datadef-34928")]
public PersonMellomnavnAndreTilknytningBeskrivelsedatadef34928 PersonMellomnavnAndreTilknytningBeskrivelsedatadef34928 { get; set; }
    [XmlElement("PersonMellomnavnAndreTilknyttetPersonsFodselsnummer-datadef-34929")]
    [JsonProperty("PersonMellomnavnAndreTilknyttetPersonsFodselsnummer-datadef-34929")]
    [JsonPropertyName("PersonMellomnavnAndreTilknyttetPersonsFodselsnummer-datadef-34929")]
public PersonMellomnavnAndreTilknyttetPersonsFodselsnummerdatadef34929 PersonMellomnavnAndreTilknyttetPersonsFodselsnummerdatadef34929 { get; set; }
    [XmlElement("PersonMellomnavnAndreTilknyttetPersonsEtternavn-datadef-34930")]
    [JsonProperty("PersonMellomnavnAndreTilknyttetPersonsEtternavn-datadef-34930")]
    [JsonPropertyName("PersonMellomnavnAndreTilknyttetPersonsEtternavn-datadef-34930")]
public PersonMellomnavnAndreTilknyttetPersonsEtternavndatadef34930 PersonMellomnavnAndreTilknyttetPersonsEtternavndatadef34930 { get; set; }
    [XmlElement("PersonMellomnavnAndreTilknyttetGardNavn-datadef-34931")]
    [JsonProperty("PersonMellomnavnAndreTilknyttetGardNavn-datadef-34931")]
    [JsonPropertyName("PersonMellomnavnAndreTilknyttetGardNavn-datadef-34931")]
public PersonMellomnavnAndreTilknyttetGardNavndatadef34931 PersonMellomnavnAndreTilknyttetGardNavndatadef34931 { get; set; }
    [XmlElement("PersonMellomnavnAndreTilknyttetGardKommunenummer-datadef-34932")]
    [JsonProperty("PersonMellomnavnAndreTilknyttetGardKommunenummer-datadef-34932")]
    [JsonPropertyName("PersonMellomnavnAndreTilknyttetGardKommunenummer-datadef-34932")]
public PersonMellomnavnAndreTilknyttetGardKommunenummerdatadef34932 PersonMellomnavnAndreTilknyttetGardKommunenummerdatadef34932 { get; set; }
    [XmlElement("PersonMellomnavnAndreTilknyttetGardGardsnummer-datadef-34933")]
    [JsonProperty("PersonMellomnavnAndreTilknyttetGardGardsnummer-datadef-34933")]
    [JsonPropertyName("PersonMellomnavnAndreTilknyttetGardGardsnummer-datadef-34933")]
public PersonMellomnavnAndreTilknyttetGardGardsnummerdatadef34933 PersonMellomnavnAndreTilknyttetGardGardsnummerdatadef34933 { get; set; }
    [XmlElement("PersonMellomnavnAndreTilknyttetGardBruksnummer-datadef-34934")]
    [JsonProperty("PersonMellomnavnAndreTilknyttetGardBruksnummer-datadef-34934")]
    [JsonPropertyName("PersonMellomnavnAndreTilknyttetGardBruksnummer-datadef-34934")]
public PersonMellomnavnAndreTilknyttetGardBruksnummerdatadef34934 PersonMellomnavnAndreTilknyttetGardBruksnummerdatadef34934 { get; set; }
    [XmlElement("PersonMellomnavnAndreTilknyttetGardFestenummer-datadef-34935")]
    [JsonProperty("PersonMellomnavnAndreTilknyttetGardFestenummer-datadef-34935")]
    [JsonPropertyName("PersonMellomnavnAndreTilknyttetGardFestenummer-datadef-34935")]
public PersonMellomnavnAndreTilknyttetGardFestenummerdatadef34935 PersonMellomnavnAndreTilknyttetGardFestenummerdatadef34935 { get; set; }
}
public class PersonMellomnavnAndredatadef34926{
[Range(1,Int32.MaxValue)]
    [XmlAttribute("orid")]
    [BindNever]
public decimal orid {get; set;} = 34926;
[MinLength(1)]
[MaxLength(50)]
    [XmlText()]
public string value { get; set; }
}
public class PersonMellomnavnAndreTilknytningstypedatadef34927{
[Range(1,Int32.MaxValue)]
    [XmlAttribute("orid")]
    [BindNever]
public decimal orid {get; set;} = 34927;
[MinLength(1)]
[MaxLength(2)]
    [XmlText()]
public string value { get; set; }
}
public class PersonMellomnavnAndreTilknytningBeskrivelsedatadef34928{
[Range(1,Int32.MaxValue)]
    [XmlAttribute("orid")]
    [BindNever]
public decimal orid {get; set;} = 34928;
[MinLength(1)]
[MaxLength(500)]
    [XmlText()]
public string value { get; set; }
}
public class PersonMellomnavnAndreTilknyttetPersonsFodselsnummerdatadef34929{
[Range(1,Int32.MaxValue)]
    [XmlAttribute("orid")]
    [BindNever]
public decimal orid {get; set;} = 34929;
    [XmlText()]
public string value { get; set; }
}
public class PersonMellomnavnAndreTilknyttetPersonsEtternavndatadef34930{
[Range(1,Int32.MaxValue)]
    [XmlAttribute("orid")]
    [BindNever]
public decimal orid {get; set;} = 34930;
[MinLength(1)]
[MaxLength(50)]
    [XmlText()]
public string value { get; set; }
}
public class PersonMellomnavnAndreTilknyttetGardNavndatadef34931{
[Range(1,Int32.MaxValue)]
    [XmlAttribute("orid")]
    [BindNever]
public decimal orid {get; set;} = 34931;
[MinLength(1)]
[MaxLength(50)]
    [XmlText()]
public string value { get; set; }
}
public class PersonMellomnavnAndreTilknyttetGardKommunenummerdatadef34932{
[Range(1,Int32.MaxValue)]
    [XmlAttribute("orid")]
    [BindNever]
public decimal orid {get; set;} = 34932;
[RegularExpression(@"[0-9]{4}")]
    [XmlText()]
public string value { get; set; }
}
public class PersonMellomnavnAndreTilknyttetGardGardsnummerdatadef34933{
[Range(1,Int32.MaxValue)]
    [XmlAttribute("orid")]
    [BindNever]
public decimal orid {get; set;} = 34933;
[MinLength(1)]
[MaxLength(5)]
    [XmlText()]
public string value { get; set; }
}
public class PersonMellomnavnAndreTilknyttetGardBruksnummerdatadef34934{
[Range(1,Int32.MaxValue)]
    [XmlAttribute("orid")]
    [BindNever]
public decimal orid {get; set;} = 34934;
[MinLength(1)]
[MaxLength(4)]
    [XmlText()]
public string value { get; set; }
}
public class PersonMellomnavnAndreTilknyttetGardFestenummerdatadef34935{
[Range(1,Int32.MaxValue)]
    [XmlAttribute("orid")]
    [BindNever]
public decimal orid {get; set;} = 34935;
[MinLength(1)]
[MaxLength(4)]
    [XmlText()]
public string value { get; set; }
}
public class TilknytningMellomnavn3grp9354{
[Range(1,Int32.MaxValue)]
    [XmlAttribute("gruppeid")]
    [BindNever]
public decimal gruppeid {get; set;} = 9354;
    [XmlElement("PersonMellomnavnTredje-datadef-34936")]
    [JsonProperty("PersonMellomnavnTredje-datadef-34936")]
    [JsonPropertyName("PersonMellomnavnTredje-datadef-34936")]
public PersonMellomnavnTredjedatadef34936 PersonMellomnavnTredjedatadef34936 { get; set; }
    [XmlElement("PersonMellomnavnTredjeTilknytningstype-datadef-34937")]
    [JsonProperty("PersonMellomnavnTredjeTilknytningstype-datadef-34937")]
    [JsonPropertyName("PersonMellomnavnTredjeTilknytningstype-datadef-34937")]
public PersonMellomnavnTredjeTilknytningstypedatadef34937 PersonMellomnavnTredjeTilknytningstypedatadef34937 { get; set; }
    [XmlElement("PersonMellomnavnTredjeTilknytningBeskrivelse-datadef-34938")]
    [JsonProperty("PersonMellomnavnTredjeTilknytningBeskrivelse-datadef-34938")]
    [JsonPropertyName("PersonMellomnavnTredjeTilknytningBeskrivelse-datadef-34938")]
public PersonMellomnavnTredjeTilknytningBeskrivelsedatadef34938 PersonMellomnavnTredjeTilknytningBeskrivelsedatadef34938 { get; set; }
    [XmlElement("PersonMellomnavnTredjeTilknyttetPersonsFodselsnummer-datadef-34939")]
    [JsonProperty("PersonMellomnavnTredjeTilknyttetPersonsFodselsnummer-datadef-34939")]
    [JsonPropertyName("PersonMellomnavnTredjeTilknyttetPersonsFodselsnummer-datadef-34939")]
public PersonMellomnavnTredjeTilknyttetPersonsFodselsnummerdatadef34939 PersonMellomnavnTredjeTilknyttetPersonsFodselsnummerdatadef34939 { get; set; }
    [XmlElement("PersonMellomnavnTredjeTilknyttetPersonsEtternavn-datadef-34940")]
    [JsonProperty("PersonMellomnavnTredjeTilknyttetPersonsEtternavn-datadef-34940")]
    [JsonPropertyName("PersonMellomnavnTredjeTilknyttetPersonsEtternavn-datadef-34940")]
public PersonMellomnavnTredjeTilknyttetPersonsEtternavndatadef34940 PersonMellomnavnTredjeTilknyttetPersonsEtternavndatadef34940 { get; set; }
    [XmlElement("PersonMellomnavnTredjeTilknyttetGardNavn-datadef-34941")]
    [JsonProperty("PersonMellomnavnTredjeTilknyttetGardNavn-datadef-34941")]
    [JsonPropertyName("PersonMellomnavnTredjeTilknyttetGardNavn-datadef-34941")]
public PersonMellomnavnTredjeTilknyttetGardNavndatadef34941 PersonMellomnavnTredjeTilknyttetGardNavndatadef34941 { get; set; }
    [XmlElement("PersonMellomnavnTredjeTilknyttetGardKommunenummer-datadef-34942")]
    [JsonProperty("PersonMellomnavnTredjeTilknyttetGardKommunenummer-datadef-34942")]
    [JsonPropertyName("PersonMellomnavnTredjeTilknyttetGardKommunenummer-datadef-34942")]
public PersonMellomnavnTredjeTilknyttetGardKommunenummerdatadef34942 PersonMellomnavnTredjeTilknyttetGardKommunenummerdatadef34942 { get; set; }
    [XmlElement("PersonMellomnavnTredjeTilknyttetGardGardsnummer-datadef-34943")]
    [JsonProperty("PersonMellomnavnTredjeTilknyttetGardGardsnummer-datadef-34943")]
    [JsonPropertyName("PersonMellomnavnTredjeTilknyttetGardGardsnummer-datadef-34943")]
public PersonMellomnavnTredjeTilknyttetGardGardsnummerdatadef34943 PersonMellomnavnTredjeTilknyttetGardGardsnummerdatadef34943 { get; set; }
    [XmlElement("PersonMellomnavnTredjeTilknyttetGardBruksnummer-datadef-34944")]
    [JsonProperty("PersonMellomnavnTredjeTilknyttetGardBruksnummer-datadef-34944")]
    [JsonPropertyName("PersonMellomnavnTredjeTilknyttetGardBruksnummer-datadef-34944")]
public PersonMellomnavnTredjeTilknyttetGardBruksnummerdatadef34944 PersonMellomnavnTredjeTilknyttetGardBruksnummerdatadef34944 { get; set; }
    [XmlElement("PersonMellomnavnTredjeTilknyttetGardFestenummer-datadef-34945")]
    [JsonProperty("PersonMellomnavnTredjeTilknyttetGardFestenummer-datadef-34945")]
    [JsonPropertyName("PersonMellomnavnTredjeTilknyttetGardFestenummer-datadef-34945")]
public PersonMellomnavnTredjeTilknyttetGardFestenummerdatadef34945 PersonMellomnavnTredjeTilknyttetGardFestenummerdatadef34945 { get; set; }
}
public class PersonMellomnavnTredjedatadef34936{
[Range(1,Int32.MaxValue)]
    [XmlAttribute("orid")]
    [BindNever]
public decimal orid {get; set;} = 34936;
[MinLength(1)]
[MaxLength(50)]
    [XmlText()]
public string value { get; set; }
}
public class PersonMellomnavnTredjeTilknytningstypedatadef34937{
[Range(1,Int32.MaxValue)]
    [XmlAttribute("orid")]
    [BindNever]
public decimal orid {get; set;} = 34937;
[MinLength(1)]
[MaxLength(2)]
    [XmlText()]
public string value { get; set; }
}
public class PersonMellomnavnTredjeTilknytningBeskrivelsedatadef34938{
[Range(1,Int32.MaxValue)]
    [XmlAttribute("orid")]
    [BindNever]
public decimal orid {get; set;} = 34938;
[MinLength(1)]
[MaxLength(500)]
    [XmlText()]
public string value { get; set; }
}
public class PersonMellomnavnTredjeTilknyttetPersonsFodselsnummerdatadef34939{
[Range(1,Int32.MaxValue)]
    [XmlAttribute("orid")]
    [BindNever]
public decimal orid {get; set;} = 34939;
    [XmlText()]
public string value { get; set; }
}
public class PersonMellomnavnTredjeTilknyttetPersonsEtternavndatadef34940{
[Range(1,Int32.MaxValue)]
    [XmlAttribute("orid")]
    [BindNever]
public decimal orid {get; set;} = 34940;
[MinLength(1)]
[MaxLength(50)]
    [XmlText()]
public string value { get; set; }
}
public class PersonMellomnavnTredjeTilknyttetGardNavndatadef34941{
[Range(1,Int32.MaxValue)]
    [XmlAttribute("orid")]
    [BindNever]
public decimal orid {get; set;} = 34941;
[MinLength(1)]
[MaxLength(50)]
    [XmlText()]
public string value { get; set; }
}
public class PersonMellomnavnTredjeTilknyttetGardKommunenummerdatadef34942{
[Range(1,Int32.MaxValue)]
    [XmlAttribute("orid")]
    [BindNever]
public decimal orid {get; set;} = 34942;
[RegularExpression(@"[0-9]{4}")]
    [XmlText()]
public string value { get; set; }
}
public class PersonMellomnavnTredjeTilknyttetGardGardsnummerdatadef34943{
[Range(1,Int32.MaxValue)]
    [XmlAttribute("orid")]
    [BindNever]
public decimal orid {get; set;} = 34943;
[MinLength(1)]
[MaxLength(5)]
    [XmlText()]
public string value { get; set; }
}
public class PersonMellomnavnTredjeTilknyttetGardBruksnummerdatadef34944{
[Range(1,Int32.MaxValue)]
    [XmlAttribute("orid")]
    [BindNever]
public decimal orid {get; set;} = 34944;
[MinLength(1)]
[MaxLength(4)]
    [XmlText()]
public string value { get; set; }
}
public class PersonMellomnavnTredjeTilknyttetGardFestenummerdatadef34945{
[Range(1,Int32.MaxValue)]
    [XmlAttribute("orid")]
    [BindNever]
public decimal orid {get; set;} = 34945;
[MinLength(1)]
[MaxLength(4)]
    [XmlText()]
public string value { get; set; }
}
public class TilknytningMellomnavnEkstragrp9355{
[Range(1,Int32.MaxValue)]
    [XmlAttribute("gruppeid")]
    [BindNever]
public decimal gruppeid {get; set;} = 9355;
    [XmlElement("PersonMellomnavnBeskrivelse-datadef-34946")]
    [JsonProperty("PersonMellomnavnBeskrivelse-datadef-34946")]
    [JsonPropertyName("PersonMellomnavnBeskrivelse-datadef-34946")]
public PersonMellomnavnBeskrivelsedatadef34946 PersonMellomnavnBeskrivelsedatadef34946 { get; set; }
}
public class PersonMellomnavnBeskrivelsedatadef34946{
[Range(1,Int32.MaxValue)]
    [XmlAttribute("orid")]
    [BindNever]
public decimal orid {get; set;} = 34946;
[MinLength(1)]
[MaxLength(500)]
    [XmlText()]
public string value { get; set; }
}
public class Begrunnelsegrp9317{
[Range(1,Int32.MaxValue)]
    [XmlAttribute("gruppeid")]
    [BindNever]
public decimal gruppeid {get; set;} = 9317;
    [XmlElement("BegrunnelseForNyttNavn-grp-9318")]
    [JsonProperty("BegrunnelseForNyttNavn-grp-9318")]
    [JsonPropertyName("BegrunnelseForNyttNavn-grp-9318")]
public BegrunnelseForNyttNavngrp9318 BegrunnelseForNyttNavngrp9318 { get; set; }
}
public class BegrunnelseForNyttNavngrp9318{
[Range(1,Int32.MaxValue)]
    [XmlAttribute("gruppeid")]
    [BindNever]
public decimal gruppeid {get; set;} = 9318;
    [XmlElement("PersonForrigeFornavnValgt-datadef-34947")]
    [JsonProperty("PersonForrigeFornavnValgt-datadef-34947")]
    [JsonPropertyName("PersonForrigeFornavnValgt-datadef-34947")]
public PersonForrigeFornavnValgtdatadef34947 PersonForrigeFornavnValgtdatadef34947 { get; set; }
    [XmlElement("PersonFornavnAnnetBegrunnelse-datadef-34948")]
    [JsonProperty("PersonFornavnAnnetBegrunnelse-datadef-34948")]
    [JsonPropertyName("PersonFornavnAnnetBegrunnelse-datadef-34948")]
public PersonFornavnAnnetBegrunnelsedatadef34948 PersonFornavnAnnetBegrunnelsedatadef34948 { get; set; }
}
public class PersonForrigeFornavnValgtdatadef34947{
[Range(1,Int32.MaxValue)]
    [XmlAttribute("orid")]
    [BindNever]
public decimal orid {get; set;} = 34947;
[RegularExpression(@"(0|1)")]
    [XmlText()]
public string value { get; set; }
}
public class PersonFornavnAnnetBegrunnelsedatadef34948{
[Range(1,Int32.MaxValue)]
    [XmlAttribute("orid")]
    [BindNever]
public decimal orid {get; set;} = 34948;
[MinLength(1)]
[MaxLength(500)]
    [XmlText()]
public string value { get; set; }
}
}
