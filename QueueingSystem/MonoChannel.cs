using System;

namespace QueueingSystem
{
    public class MonoChannel
    {
        /// <summary>
        /// Average intensity of incoming calls flow
        /// </summary>
        double lambda;

        /// <summary>
        /// Average time between successful call income
        /// </summary>
        double iat;

        /// <summary>
        /// Average servicing time
        /// </summary>
        double st;

        /// <summary>
        /// Expected service channel load
        /// </summary>
        double rho;

        double avgCallsAmount;
        double avgCallsAmountInQueue;
        double avgTimeInSystem;
        double avgTimeInQueue;
        double avgBusySystemPeriod;
        double probSystemFree;
        double probSystemBusy;

        public MonoChannel(double _lambda, double _st)
        {
            lambda = _lambda;
            iat = 1 / lambda;
            st = _st;
            rho = lambda * st;

            Calculation();
        }

        public void Calculation()
        {
            avgCallsAmount = rho / (1.0 - rho);
            avgCallsAmountInQueue = avgCallsAmount - rho;

            avgTimeInSystem = avgCallsAmount * iat;
            avgTimeInQueue = avgTimeInSystem - st;

            avgBusySystemPeriod = 1 / (1 / st - lambda);
            probSystemFree = 1 /
                            (1 + rho / (1 - rho));
            probSystemBusy = 1 - probSystemFree;
        }
        public void PrintResults()
        {
            Console.WriteLine();
            Console.WriteLine($"\t\t\tLAMBDA = {lambda}; st = {st}");
            Console.WriteLine(
                $"rho \t= {rho}\n" +
                $"L \t= {avgCallsAmount:N3}\n" +
                $"Lq \t= {avgCallsAmountInQueue:N3}\n" +
                $"W \t= {avgTimeInSystem:N3}\n" +
                $"Wq \t= {avgTimeInQueue:N3}\n" +
                $"B \t= {avgBusySystemPeriod:N3}\n" +
                $"p0 \t= {probSystemFree:N3}\n" +
                $"p \t= {probSystemBusy:N3}\n");
        }
    }
}
