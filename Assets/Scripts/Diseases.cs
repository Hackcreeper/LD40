﻿namespace LD40
{
    public class Diseases
    {
        public static string[] All = {
            "Abdominal Aortic Aneurysm",
            "Acanthamoeba Infection",
            "Acquired Immune Deficiency Syndrome",
            "Acinetobacter Infection",
            "Acquired Immunodeficiency Syndrome",
            "Adenovirus Infection",
            "ADHD ",
            "Adenovirus Vaccination",
            "ACE",
            "Atrial fibrillation",
            "African Trypanosomiasis",
            "Agricultural Safety",
            "Alkhurma hemorrhagic fever",
            "Acquired Immune Deficiency Syndrome",
            "AIDS",
            "Alkhurma hemorrhagic fever",
            "Amyotrophic Lateral Sclerosis",
            "Alzheimer's Disease",
            "Entamoeba histolytica infection",
            "Chagas Disease",
            "Anaplasmosis",
            "Ancylostoma duodenale Infection",
            "Angiostrongylus Infection",
            "Anisakis Infection",
            "Bacillus anthracis Infection",
            "Aortic Aneurysm",
            "Arenavirus Infection",
            "Arthritis",
            "Fibromyalgia",
            "Osteoarthritis",
            "Rheumatoid Arthritis",
            "Ascariasis",
            "Ascaris Infection",
            "Aseptic Meningitis",
            "Aspergillosis",
            "Aspergillus Infection",
            "Asthma",
            "Atrial fibrillation",
            "Attention Deficit/Hyperactivity Disorder",
            "Avian Influenza",
            "Herpes B virus",
            "Cepacia infection",
            "Babesia Infection",
            "Bacillus anthracis Infection",
            "Back Belts",
            "Bacterial Meningitis",
            "Bacterial Vaginosis",
            "Balamuthia mandrillaris Infection",
            "Balamuthia Infection",
            "Balantidium Infection",
            "Bartonella bacilliformis Infection",
            "Bartonella quintana Infection",
            "Baylisascaris Infection",
            "BCG",
            "Bilharzia",
            "Avian Influenza",
            "Black Lung",
            "Blastocystis hominis Infection",
            "Blastocystis Infection",
            "blood clot",
            "Pediculus humanus corporis",
            "Borrelia burgdorferi Infection",
            "Clostridium botulinum Infection",
            "Bovine Spongiform Encephalopathy",
            "Diarrhea",
            "Breast Cancer",
            "Respiratory Syncytial Virus Infection",
            "Bronchitis",
            "Brucella Infection",
            "Brucella Infection",
            "Bovine Spongiform Encephalopathy",
            "Mad Cow Disease",
            "Burkholderia cepacia Infection",
            "Burkholderia mallei",
            "Burkholderia pseudomallei Infection",
            "Bacterial Vaginosis",
            "Clostridium difficile Infection",
            "Campylobacter Infection",
            "Campylobacter Infection",
            "Cancer",
            "Colorectal Cancer",
            "Gynecologic Cancers",
            "Lung Cancer",
            "Prostate Cancer",
            "Skin Cancer",
            "Cancer and Flu",
            "Candida Infection",
            "Genital Candidiasis",
            "Invasive Candidiasis",
            "Oropharyngeal Candidiasis",
            "Canine Flu",
            "Capillaria Infection",
            "Capillariasis",
            "Carbapenem resistant Klebsiella pneumonia",
            "Carbapenem-resistant Enterobacteriaceae",
            "Carpal Tunnel Syndrome",
            "Bartonella bacilliformis Infection",
            "Crimean-Congo hemorrhagic fever",
            "Cercarial Dermatitis",
            "Cerebral Palsy",
            "Cervical Cancer",
            "Chronic Fatigue Syndrome",
            "Trypanosoma cruzi Infection",
            "Chapare Hemorrhagic Fever",
            "Chapare Hemorrhagic Fever",
            "Varicella Disease",
            "Chickenpox Vaccination",
            "Chikungunya Fever",
            "Chlamydia trachomatis Disease",
            "Chlamydophila pneumoniae Infection",
            "Vibrio cholerae Infection",
            "Chronic Fatigue Syndrome",
            "Chronic Kidney Disease",
            "Chronic Obstructive Pulmonary Disease",
            "Chronic Wasting Disease",
            "Ciguatera Fish Poisoning",
            "Ciguatoxin",
            "Classic Creutzfeldt-Jakob Disease",
            "Clonorchis Infection",
            "Clostridium botulinum Infection",
            "Clostridium difficile Infection",
            "Clostridium perfringens infection",
            "Clostridium tetani Infection",
            "Clotting Disorders",
            "Cytomegalovirus Infection",
            "Coccidioidomycosis",
            "Cold",
            "Colorado Tick Fever",
            "Colorectal Cancer",
            "Common Cold",
            "Traumatic Brain Injury",
            "Congenital Hearing Loss",
            "Congenital Heart Defects",
            "Conjunctivitis",
            "Cooley's Anemia",
            "Chronic Obstructive Pulmonary Disease",
            "Corynebacterium diphtheriae Infection",
            "Coxiella burnetii Infection",
            "Carbapenem-resistant Enterobacteriaceae"
        };

        public static string Random()
        {
            return All[UnityEngine.Random.Range(0, All.Length - 1)];
        }
    }
}