const { Firestore } = require('@google-cloud/firestore');

const db = new Firestore();
const predictCollection = db.collection('predictions');

async function storeData(id, data) {
  return predictCollection.doc(id).set(data);
}

const getHistoriesData = async () => {
  const documentCollection = await predictCollection.get();
  const predictions = [];

  documentCollection.forEach((doc) => {
    const data = doc.data();
    predictions.push({
      id: doc.id, // Ensure the document ID is included
      history: {
        result: data.result,
        createdAt: data.createdAt,
        suggestion: data.suggestion,
      },
    });
  });

  return predictions;
};

module.exports = {
  storeData,
  getHistoriesData,
};
