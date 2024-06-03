const predictCancer = require('../services/inferenceService');
const crypto = require('crypto');
const { storeData, getHistoriesData } = require('../services/storeData');

async function postPredictHandler(request, h) {
  const { image } = request.payload;
  const { model } = request.server.app;

  const { confidenceScore, label, suggestion } = await predictCancer(
    model,
    image
  );
  const id = crypto.randomUUID();
  const createdAt = new Date().toISOString();

  const data = {
    id: id,
    result: label,
    suggestion: suggestion,
    createdAt: createdAt,
  };

  await storeData(id, data);

  const response = h.response({
    status: 'success',
    message: 'Model is predicted successfully',
    data,
  });
  response.code(201);
  return response;
}

async function getAllPredictsHandler(request, h) {
  try {
    const predictions = await getHistoriesData();

    const mappedPredictions = predictions.map((prediction) => ({
      id: prediction.id,
      history: {
        result: prediction.history.result,
        createdAt: prediction.history.createdAt,
        suggestion: prediction.history.suggestion,
        id: prediction.history.id,
      },
    }));

    return h
      .response({
        status: 'success',
        data: mappedPredictions,
      })
      .code(200);
  } catch (error) {
    console.error('Error fetching predictions:', error);
    return h
      .response({ status: 'error', error: 'Failed to fetch predictions' })
      .code(500);
  }
}

module.exports = { postPredictHandler, getAllPredictsHandler };
