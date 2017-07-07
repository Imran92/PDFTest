using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PDFTest.ViewModels
{
    public class PdfSubmitModel
    {
        public string PatientName { get; set; }
        public string Date { get; set; }

        public bool VisitTypeInitial { get; set; }
        public bool VisitTypeRevisit { get; set; }
        public bool VisitTypeHospitalization { get; set; }
        public bool VisitTypeChangeStatus { get; set; }

        public bool HomeboundAssistanceForAllActivity { get; set; }
        public bool HomeboundResidualWeakness { get; set; }
        public bool HomeboundAssistanceToAmbulate { get; set; }
        public bool HomeboundConfusion { get; set; }
        public bool HomeboundSevereSob { get; set; }
        public bool HomeboundDependentUponAdaptiveDevice { get; set; }
        public bool HomeboundMedicalRestrictions { get; set; }
        public bool HomeboundOther { get; set; }
        public string HomeboundOtherSpecify { get; set; }


        public bool SkilledObservationMentalNoChange { get; set; }
        public bool SkilledObservationMentalAlert { get; set; }
        public bool SkilledObservationMentalConfused { get; set; }
        public bool SkilledObservationMentalForgetful { get; set; }
        public bool SkilledObservationMentalDisoriented { get; set; }
        public bool SkilledObservationMentalAgitated { get; set; }
        public string SkilledObservationTemperature { get; set; }
        public bool SkilledObservationTemperatureOral { get; set; }
        public bool SkilledObservationTemperatureAxiliary { get; set; }
        public bool SkilledObservationTemperatureTympanic { get; set; }
        public bool SkilledObservationTemperatureRectal { get; set; }
        public string SkilledObservationPulse { get; set; }
        public bool SkilledObservationPulseRadial { get; set; }
        public bool SkilledObservationPulseApical { get; set; }
        public bool SkilledObservationPulseBrachial { get; set; }
        public bool SkilledObservationPulseRegular { get; set; }
        public bool SkilledObservationPulseIrregular { get; set; }
        public string SkilledObservationRespiration { get; set; }
        public bool SkilledObservationRespirationRegular { get; set; }
        public bool SkilledObservationRespirationIrregular { get; set; }
        public string SkilledObservationBpRight1 { get; set; }
        public string SkilledObservationBpRight2 { get; set; }
        public string SkilledObservationBpLeft1 { get; set; }
        public string SkilledObservationBpLeft2 { get; set; }
        public bool SkilledObservationLying { get; set; }
        public bool SkilledObservationStanding { get; set; }
        public bool SkilledObservationSitting { get; set; }
        public string SkilledObservationWeight { get; set; }
        public bool SkilledObservationWeightActual { get; set; }
        public bool SkilledObservationWeightReported { get; set; }
        public string SkilledObservationSugar { get; set; }
        public bool SkilledObservationSugarActual { get; set; }
        public bool SkilledObservationSugarReported { get; set; }
        public string SkilledObservationSkin { get; set; }
        public bool SkilledObservationBreathClear { get; set; }
        public bool SkilledObservationBreathCrackles { get; set; }
        public bool SkilledObservationBreathRhonchi { get; set; }
        public string SkilledObservationBreathOther { get; set; }
        public string SkilledObservationOxygen { get; set; }
        public bool SkilledObservationBowelActive { get; set; }
        public bool SkilledObservationBowelAbsent { get; set; }
        public bool SkilledObservationBowelHypoactive { get; set; }
        public bool SkilledObservationBowelHyperactive { get; set; }
        public string SkilledObservationBowelQuadrants { get; set; }
        public string SkilledObservationLastBM { get; set; }
        public bool SkilledObservationLastBMIncontinence { get; set; }
        public bool SkilledObservationLastBMDiarrhea { get; set; }
        public bool SkilledObservationLastBMConstipation { get; set; }
        public bool SkilledObservationLastBMImpaction { get; set; }
        public bool SkilledObservationPainNone { get; set; }
        public bool SkilledObservationPainSame { get; set; }
        public bool SkilledObservationPainImproved { get; set; }
        public bool SkilledObservationPainWorse { get; set; }
        public string SkilledObservationPainOrigin { get; set; }
        public string SkilledObservationPainLocation { get; set; }


        public string SkilledObservationHearing { get; set; }
        public string SkilledObservationVision { get; set; }
        public string SkilledObservationReliefMeasures { get; set; }



        public bool CardiopulmonaryNoProblem { get; set; }
        public bool CardiopulmonaryChestPain { get; set; }
        public bool CardiopulmonaryPedalEdema { get; set; }
        public string CardiopulmonaryPedalEdemaOther { get; set; }
        public bool CardiopulmonaryPedalEdema1 { get; set; }
        public bool CardiopulmonaryPedalEdema2 { get; set; }
        public bool CardiopulmonaryPedalEdema3 { get; set; }
        public bool CardiopulmonaryPedalEdema4 { get; set; }
        public bool CardiopulmonaryPedalPulseBool { get; set; }
        public string CardiopulmonaryPedalPulses { get; set; }
        public bool CardiopulmonaryPedalPulsesAbsent { get; set; }
        public bool CardiopulmonaryCough { get; set; }
        public bool CardiopulmonaryCoughNonProductive { get; set; }
        public bool CardiopulmonaryCoughProductive { get; set; }
        public string CardiopulmonaryCoughColor { get; set; }
        public string CardiopulmonaryCoughCharacter { get; set; }
        public bool CardiopulmonaryDyspnea { get; set; }
        public bool CardiopulmonaryOrthopnea { get; set; }
        public bool CardiopulmonaryCyanosis { get; set; }
        public bool CardiopulmonaryOxygen { get; set; }
        public string CardiopulmonaryOxygenLitres { get; set; }
        public bool CardiopulmonaryOxygenNc { get; set; }
        public bool CardiopulmonaryOxygenMask { get; set; }
        public bool CardiopulmonaryOxygenTrach { get; set; }
        public bool CardiopulmonaryPRN { get; set; }
        public string CardiopulmonaryComments { get; set; }
        public string CardiopulmonaryTrachType { get; set; }
        public string CardiopulmonaryTrachSize { get; set; }
        public bool CardiopulmonaryRR { get; set; }
        public bool CardiopulmonaryTV { get; set; }
        public bool CardiopulmonaryPEEP { get; set; }



        public bool NeuromuscularNoProblem { get; set; }
        public bool NeuromuscularPeerla { get; set; }
        public bool NeuromuscularOtherCheck { get; set; }
        public string NeuromuscularOther { get; set; }
        public bool NeuromuscularDecreasedSensation { get; set; }
        public bool NeuromuscularTremors { get; set; }
        public bool NeuromuscularHeadache { get; set; }
        public bool NeuromuscularGraspRightEqual { get; set; }
        public bool NeuromuscularGraspRightUnequal { get; set; }
        public bool NeuromuscularGraspRightOtherCheck { get; set; }
        public string NeuromuscularGraspRightOther { get; set; }
        public bool NeuromuscularGraspLeftEqual { get; set; }
        public bool NeuromuscularGraspLeftUnequal { get; set; }
        public bool NeuromuscularGraspLeftOtherCheck { get; set; }
        public string NeuromuscularGraspLeftOther { get; set; }
        public bool NeuromuscularNumbness { get; set; }
        public bool NeuromuscularVertigo { get; set; }
        public bool NeuromuscularSyncope { get; set; }
        public bool NeuromuscularAmbulates { get; set; }
        public bool NeuromuscularAmbulatesIndependent { get; set; }
        public bool NeuromuscularAmbulatesAssist { get; set; }
        public bool NeuromuscularAmbulatesEquipment { get; set; }
        public bool NeuromuscularEquipmentBalance { get; set; }
        public bool NeuromuscularEquipmentBalanceWnl { get; set; }
        public bool NeuromuscularEquipmentBalanceUnsteady { get; set; }
        public bool NeuromuscularWeakness { get; set; }
        public bool NeuromuscularAdaptiveEquipment { get; set; }
        public string NeuromuscularAdaptiveEquipmentComment { get; set; }
        public string NeuromuscularComments1 { get; set; }
        public string NeuromuscularComments2 { get; set; }
        public string NeuromuscularComments3 { get; set; }


        public bool GastrointestinalAnorexia { get; set; }
        public bool GastrointestinalNausea { get; set; }
        public bool GastrointestinalDifficulty { get; set; }
        public bool GastrointestinalTube { get; set; }
        public string GastrointestinalTubeSpecify { get; set; }
        public bool GastrointestinalTubeContinuous { get; set; }
        public bool GastrointestinalTubeIntermittent { get; set; }



        public bool GenitourinaryBurning { get; set; }
        public bool GenitourinaryFrequency { get; set; }
        public bool GenitourinaryRetention { get; set; }
        public bool GenitourinaryOdor { get; set; }
        public bool GenitourinaryHematuria { get; set; }
        public bool GenitourinaryIncontinence { get; set; }
        public bool GenitourinaryCatheter { get; set; }
        public string GenitourinaryCatheterType { get; set; }
        public string GenitourinaryFrench { get; set; }
        public string GenitourinaryBulbInflated { get; set; }
        public bool GenitourinaryBulbChanged { get; set; }
        public bool GenitourinaryBulbInserted { get; set; }
        public bool GenitourinaryBulbRemoved { get; set; }
        public string GenitourinaryIrrigated { get; set; }
        public string GenitourinaryComments { get; set; }


        public bool WoundCareNotApplicable { get; set; }
        public bool WoundCareGiver { get; set; }
        public bool WoundCareDressingRemoved { get; set; }
        public bool WoundCareCleaned { get; set; }
        public string WoundCareCleanedSpecify { get; set; }
        public bool WoundCareIrrigated { get; set; }
        public string WoundCareIrrigatedSpecify { get; set; }
        public bool WoundCareDressing { get; set; }
        public string WoundCareDressingType { get; set; }
        public bool WoundCareDebridment { get; set; }
        public bool WoundCareDrainage { get; set; }
        public bool WoundCareDrainageCollection { get; set; }
        public string WoundCareDrainageCollectionVolume { get; set; }
        public bool WoundCareTolerated { get; set; }
        public bool WoundCareMedicated { get; set; }
        public bool WoundCareInstructed { get; set; }
        public bool WoundCarePerformChange { get; set; }

        public string WoundLocation1 { get; set; }
        public string WoundLocation2 { get; set; }
        public string WoundLocation3 { get; set; }
        public string WoundLength1 { get; set; }
        public string WoundLength2 { get; set; }
        public string WoundLength3 { get; set; }
        public string WoundWidth1 { get; set; }
        public string WoundWidth2 { get; set; }
        public string WoundWidth3 { get; set; }
        public string WoundDepth1 { get; set; }
        public string WoundDepth2 { get; set; }
        public string WoundDepth3 { get; set; }
        public string WoundDrainage1 { get; set; }
        public string WoundDrainage2 { get; set; }
        public string WoundDrainage3 { get; set; }
        public string WoundTunneling1 { get; set; }
        public string WoundTunneling2 { get; set; }
        public string WoundTunneling3 { get; set; }
        public string WoundOdor1 { get; set; }
        public string WoundOdor2 { get; set; }
        public string WoundOdor3 { get; set; }
        public string WoundStoma1 { get; set; }
        public string WoundStoma2 { get; set; }
        public string WoundStoma3 { get; set; }
        public string WoundCommentLine1 { get; set; }
        public string WoundCommentLine2 { get; set; }
        public string WoundCommentLine3 { get; set; }
        public string WoundCommentLine4 { get; set; }
        

        public bool InterventionsObserve { get; set; }
        public bool InterventionsProcess { get; set; }
        public string InterventionsProcessSpecify { get; set; }
        public bool InterventionsDiet { get; set; }
        public string InterventionsDietSpecify { get; set; }
        public bool InterventionsSafety { get; set; }
        public bool InterventionsSafetyFall { get; set; }
        public bool InterventionsSafetyMedications { get; set; }
        public bool InterventionsSafetyFire { get; set; }
        public bool InterventionsOther { get; set; }
        public string InterventionsOtherSpecify { get; set; }
        public bool InterventionsPain { get; set; }
        public bool InterventionsCare { get; set; }
        public bool InterventionsTerminally { get; set; }
        public bool InterventionsVentilator { get; set; }
        public bool InterventionsTracheostomy { get; set; }
        public bool InterventionsCVA { get; set; }
        public bool InterventionsWound { get; set; }
        public bool InterventionsDiabetes { get; set; }
        public string InterventionsDiabetesManagement1 { get; set; }
        public string InterventionsDiabetesManagement2 { get; set; }
        public string InterventionsDiabetesManagement3 { get; set; }
        public bool InterventionsTubeFeedings { get; set; }
        public string InterventionsTubeFeedingsSpecify { get; set; }
        public bool InterventionsMedication { get; set; }
        public bool InterventionsMedicationInjection { get; set; }
        public bool InterventionsMedicationGt { get; set; }
        public bool InterventionsNebulizer { get; set; }
        public bool InterventionsInfusion { get; set; }
        public bool InterventionsMedicationPurpose { get; set; }
        public bool InterventionsAmbu { get; set; }
        public bool InterventionsOxygen { get; set; }
        public bool InterventionsVentilatorSettings { get; set; }
        public bool InterventionsMiscellaneous { get; set; }
        public string InterventionsMiscellaneous1 { get; set; }
        public bool InterventionsMiscellaneous2 { get; set; }

        public bool SummaryCarePlan { get; set; }
        public bool SummaryCarePlanOutcome { get; set; }
        public bool SummaryCarePlanPrn { get; set; }
        public bool SummaryCarePlanDischarge { get; set; }
        public string SummaryCarePlanForVisit1 { get; set; }
        public string SummaryCarePlanPlanForVisit2 { get; set; }
        public string SummaryCarePlanPlanForVisit3 { get; set; }
        public string SummaryCarePlanDate1 { get; set; }
        public string SummaryCarePlanDate2 { get; set; }
        public string SummaryCarePlanDate3 { get; set; }
        public string SummaryCarePlanPhysicianDate1 { get; set; }
        public string SummaryCarePlanPhysicianDate2 { get; set; }
        public string SummaryCarePlanPhysicianDate3 { get; set; }
        public bool SummaryCarePlanCoordinationMd { get; set; }
        public bool SummaryCarePlanCoordinationSn { get; set; }
        public bool SummaryCarePlanCoordinationPt { get; set; }
        public bool SummaryCarePlanCoordinationOt { get; set; }
        public bool SummaryCarePlanCoordinationSt { get; set; }
        public bool SummaryCarePlanCoordinationMsw { get; set; }
        public bool SummaryCarePlanCoordinationLpn { get; set; }
        public bool SummaryCarePlanPdn { get; set; }
        public bool SummaryCarePlanBillableYes { get; set; }
        public bool SummaryCarePlanBillableNo { get; set; }

    }
}