﻿// This file was auto-generated by ML.NET Model Builder.
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.ML.Data;
using Microsoft.ML.Trainers.LightGbm;
using Microsoft.ML.Trainers;
using Microsoft.ML;

namespace GeneradorDeInformacion
{
    public partial class ModeloCalendario
    {
        public const string RetrainFilePath =  @"C:\Users\uri_s\OneDrive\Documentos\TrabajoGrupal-PrograWebIII\GeneradorDeInformacion\bin\Debug\net8.0\data\reportePrediccionCalendario.csv";
        public const char RetrainSeparatorChar = ',';
        public const bool RetrainHasHeader =  true;

         /// <summary>
        /// Train a new model with the provided dataset.
        /// </summary>
        /// <param name="outputModelPath">File path for saving the model. Should be similar to "C:\YourPath\ModelName.mlnet"</param>
        /// <param name="inputDataFilePath">Path to the data file for training.</param>
        /// <param name="separatorChar">Separator character for delimited training file.</param>
        /// <param name="hasHeader">Boolean if training file has a header.</param>
        public static void Train(string outputModelPath, string inputDataFilePath = RetrainFilePath, char separatorChar = RetrainSeparatorChar, bool hasHeader = RetrainHasHeader)
        {
            var mlContext = new MLContext();

            var data = LoadIDataViewFromFile(mlContext, inputDataFilePath, separatorChar, hasHeader);
            var model = RetrainModel(mlContext, data);
            SaveModel(mlContext, model, data, outputModelPath);
        }

        /// <summary>
        /// Load an IDataView from a file path.
        /// </summary>
        /// <param name="mlContext">The common context for all ML.NET operations.</param>
        /// <param name="inputDataFilePath">Path to the data file for training.</param>
        /// <param name="separatorChar">Separator character for delimited training file.</param>
        /// <param name="hasHeader">Boolean if training file has a header.</param>
        /// <returns>IDataView with loaded training data.</returns>
        public static IDataView LoadIDataViewFromFile(MLContext mlContext, string inputDataFilePath, char separatorChar, bool hasHeader)
        {
            return mlContext.Data.LoadFromTextFile<ModelInput>(inputDataFilePath, separatorChar, hasHeader);
        }



        /// <summary>
        /// Save a model at the specified path.
        /// </summary>
        /// <param name="mlContext">The common context for all ML.NET operations.</param>
        /// <param name="model">Model to save.</param>
        /// <param name="data">IDataView used to train the model.</param>
        /// <param name="modelSavePath">File path for saving the model. Should be similar to "C:\YourPath\ModelName.mlnet.</param>
        public static void SaveModel(MLContext mlContext, ITransformer model, IDataView data, string modelSavePath)
        {
            // Pull the data schema from the IDataView used for training the model
            DataViewSchema dataViewSchema = data.Schema;

            using (var fs = File.Create(modelSavePath))
            {
                mlContext.Model.Save(model, dataViewSchema, fs);
            }
        }


        /// <summary>
        /// Retrains model using the pipeline generated as part of the training process.
        /// </summary>
        /// <param name="mlContext"></param>
        /// <param name="trainData"></param>
        /// <returns></returns>
        public static ITransformer RetrainModel(MLContext mlContext, IDataView trainData)
        {
            var pipeline = BuildPipeline(mlContext);
            var model = pipeline.Fit(trainData);

            return model;
        }


        /// <summary>
        /// build the pipeline that is used from model builder. Use this function to retrain model.
        /// </summary>
        /// <param name="mlContext"></param>
        /// <returns></returns>
        public static IEstimator<ITransformer> BuildPipeline(MLContext mlContext)
        {
            // Data process configuration with pipeline data transformations
            var pipeline = mlContext.Transforms.ReplaceMissingValues(new []{new InputOutputColumnPair(@"Id", @"Id"),new InputOutputColumnPair(@"PromedioPromocionAlumno", @"PromedioPromocionAlumno"),new InputOutputColumnPair(@"CantMateriasElegidas", @"CantMateriasElegidas"),new InputOutputColumnPair(@"MenorPromedioPromocionMateria", @"MenorPromedioPromocionMateria"),new InputOutputColumnPair(@"IdMateria", @"IdMateria"),new InputOutputColumnPair(@"PromedioPromocionMateria", @"PromedioPromocionMateria"),new InputOutputColumnPair(@"InicioMayorTiempoLibre", @"InicioMayorTiempoLibre"),new InputOutputColumnPair(@"FinMayorTiempoLibre", @"FinMayorTiempoLibre"),new InputOutputColumnPair(@"InicioPrediccionHorarioEstudio", @"InicioPrediccionHorarioEstudio")})      
                                    .Append(mlContext.Transforms.Text.FeaturizeText(inputColumnName:@"Dia",outputColumnName:@"Dia"))      
                                    .Append(mlContext.Transforms.Concatenate(@"Features", new []{@"Id",@"PromedioPromocionAlumno",@"CantMateriasElegidas",@"MenorPromedioPromocionMateria",@"IdMateria",@"PromedioPromocionMateria",@"InicioMayorTiempoLibre",@"FinMayorTiempoLibre",@"InicioPrediccionHorarioEstudio",@"Dia"}))      
                                    .Append(mlContext.Regression.Trainers.LightGbm(new LightGbmRegressionTrainer.Options(){NumberOfLeaves=4,NumberOfIterations=2399,MinimumExampleCountPerLeaf=21,LearningRate=0.273197123717869,LabelColumnName=@"FinPrediccionHorarioEstudio",FeatureColumnName=@"Features",ExampleWeightColumnName=null,Booster=new GradientBooster.Options(){SubsampleFraction=0.725820354184801,FeatureFraction=0.876800998083466,L1Regularization=5.151861038873E-10,L2Regularization=0.999999776672986},MaximumBinCountPerFeature=290}));

            return pipeline;
        }
    }
 }
